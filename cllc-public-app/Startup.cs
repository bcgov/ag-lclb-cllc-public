// change to a #define to enable MSSQL
#undef USE_MSSQL

using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Public.Authentication;
using Gov.Lclb.Cllb.Public.Authorization;
using Gov.Lclb.Cllb.Public.Contexts;
using Gov.Lclb.Cllb.Public.Models;
using Gov.Lclb.Cllb.Services.FileManager;
using Grpc.Net.Client;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using NWebsec.AspNetCore.Mvc;
using NWebsec.AspNetCore.Mvc.Csp;
using Serilog;
using Serilog.Exceptions;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using static Gov.Lclb.Cllb.Services.FileManager.FileManager;

namespace Gov.Lclb.Cllb.Public
{
    public class Startup
    { 

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        readonly string MyAllowSpecificOrigins = "script-src 'self' 'unsafe-eval' 'unsafe-inline' https://apis.google.com https://maxcdn.bootstrapcdn.com https://cdnjs.cloudflare.com https://code.jquery.com https://stackpath.bootstrapcdn.com https://fonts.googleapis.com";

        public IConfiguration _configuration { get; }

        public IWebHostEnvironment _env { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services )
        {
            // add a singleton for data access.
#if (USE_MSSQL)
            string connectionString = DatabaseTools.GetConnectionString(Configuration);
            string databaseName = DatabaseTools.GetDatabaseName(Configuration);

            DatabaseTools.CreateDatabaseIfNotExists(Configuration);

            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(connectionString));
#endif
            // add singleton to allow Controllers to query the Request object
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // determine if we wire up Dynamics.
            if (!string.IsNullOrEmpty(_configuration["DYNAMICS_ODATA_URI"]))
            {
                SetupServices(services);
            }

            
            // Add a memory cache
            services.AddMemoryCache();

            // for security reasons, the following headers are set.
            services.AddMvc(opts =>
            {
                opts.EnableEndpointRouting = false;
                // default deny
                var policy = new AuthorizationPolicyBuilder()
                 .RequireAuthenticatedUser()
                 .Build();
                opts.Filters.Add(new AuthorizeFilter(policy));

                opts.Filters.Add(typeof(NoCacheHttpHeadersAttribute));
                opts.Filters.Add(new XRobotsTagAttribute() { NoIndex = true, NoFollow = true });
                opts.Filters.Add(typeof(XContentTypeOptionsAttribute));
                opts.Filters.Add(typeof(XDownloadOptionsAttribute));
                opts.Filters.Add(typeof(XFrameOptionsAttribute));
                opts.Filters.Add(typeof(XXssProtectionAttribute));
                //CSPReportOnly
                opts.Filters.Add(typeof(CspReportOnlyAttribute));
                opts.Filters.Add(new CspScriptSrcReportOnlyAttribute { None = true });
            })
            .AddNewtonsoftJson(opts =>
           {
               opts.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
               opts.SerializerSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat;
               opts.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;

                // ReferenceLoopHandling is set to Ignore to prevent JSON parser issues with the user / roles model.
                opts.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
           })
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);            

            // setup siteminder authentication (core 2.0)
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = SiteMinderAuthOptions.AuthenticationSchemeName;
                options.DefaultChallengeScheme = SiteMinderAuthOptions.AuthenticationSchemeName;
            }).AddSiteminderAuth(options =>
            {

            });

            // setup authorization
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Business-User", policy =>
                                  policy.RequireClaim(User.UserTypeClaim, "Business"));
            });
            services.RegisterPermissionHandler();
            if (!string.IsNullOrEmpty (_configuration["KEY_RING_DIRECTORY"]))
            {
                // setup key ring to persist in storage.
                services.AddDataProtection().PersistKeysToFileSystem(new DirectoryInfo(_configuration["KEY_RING_DIRECTORY"]));
            }

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });

            // allow for large files to be uploaded
            services.Configure<FormOptions>(options =>
            {
                options.MultipartBodyLengthLimit = 1073741824; // 1 GB
            });

            var orgBook = new OrgBookClient(new HttpClient());
            orgBook.ReadResponseAsString = true;
            services.AddTransient<IOrgBookClient>(_ => (IOrgBookClient)orgBook);

            // health checks
            services.AddHealthChecks()
                .AddCheck("cllc_public_app", () => HealthCheckResult.Healthy())
                // No longer checking SQL Server in health checks as the SQL components are no longer active.
#if (USE_MSSQL)
                .AddSqlServer(DatabaseTools.GetConnectionString(Configuration), name: "Sql server")
#endif
                .AddCheck<DynamicsHealthCheck>("Dynamics")
                .AddCheck<GeocoderHealthCheck>("Geocoder");

            

            
            if (!string.IsNullOrEmpty(_configuration["REDIS_SERVER"]))
            {
                services.AddDistributedRedisCache(o =>
                {
                    string config = _configuration["REDIS_SERVER"];
                    if (! string.IsNullOrEmpty(_configuration["REDIS_PASSWORD"]))
                    {
                        string redisPassword = _configuration["REDIS_PASSWORD"];
                        config += $",password={redisPassword}";
                    }
                    o.Configuration = config;                    
                });
            }

            // session will automatically use redis or another distributed cache if it is available.
            services.AddSession(x => {
                x.IdleTimeout = TimeSpan.FromHours(4.0);
                x.Cookie.IsEssential = true;
            });

        }

        private void SetupServices(IServiceCollection services)
        {

            string dynamicsOdataUri = _configuration["DYNAMICS_ODATA_URI"];
            string aadTenantId = _configuration["DYNAMICS_AAD_TENANT_ID"];
            string serverAppIdUri = _configuration["DYNAMICS_SERVER_APP_ID_URI"];
            string clientKey = _configuration["DYNAMICS_CLIENT_KEY"];
            string clientId = _configuration["DYNAMICS_CLIENT_ID"];

            string ssgUsername = _configuration["SSG_USERNAME"];
            string ssgPassword = _configuration["SSG_PASSWORD"];

            AuthenticationResult authenticationResult = null;
            
            

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins("https://localhost",
                                        "http://cannabis-licensing-dev.pathfinder.bcgov",
                                        "http://cannabis-licensing-test.pathfinder.bcgov",
                                        "http://cannabis-licensing-prod.pathfinder.bcgov",
                                        "https://dev.justice.gov.bc.ca",
                                        "https://test.justice.gov.bc.ca",
                                        "https://justice.gov.bc.ca");
                });
            });


            services.AddTransient(new Func<IServiceProvider, IDynamicsClient>((serviceProvider) =>
            {

                IDynamicsClient client = DynamicsSetupUtil.SetupDynamics(_configuration);

                return client;
            }));
            

            // add BCeID Web Services

            string bceidUrl = _configuration["BCEID_SERVICE_URL"];
            string bceidSvcId = _configuration["BCEID_SERVICE_SVCID"];
            string bceidUserid = _configuration["BCEID_SERVICE_USER"];
            string bceidPasswd = _configuration["BCEID_SERVICE_PASSWD"];

            services.AddTransient<BCeIDBusinessQuery>(_ => new BCeIDBusinessQuery(bceidSvcId, bceidUserid, bceidPasswd, bceidUrl));

            // add BCEP services

            var bcep_svc_url = _configuration["BCEP_SERVICE_URL"];
            var bcep_svc_svcid = _configuration["BCEP_MERCHANT_ID"];
            var bcep_svc_hashid = _configuration["BCEP_HASH_KEY"];
            var bcep_base_uri = _configuration["BASE_URI"];
            var bcep_base_path = _configuration["BASE_PATH"];
            var bcep_conf_path = _configuration["BCEP_CONF_PATH"];

            services.AddTransient<BCEPWrapper>(_ => new BCEPWrapper(bcep_svc_url, bcep_svc_svcid, bcep_svc_hashid,
                bcep_base_uri + bcep_base_path + bcep_conf_path));
          
            // add the PDF client.
            string pdf_service_base_uri = _configuration["PDF_SERVICE_BASE_URI"];
            string bearer_token = $"Bearer {_configuration["PDF_JWT_TOKEN"]}";

            services.AddTransient<PdfClient>(_ => new PdfClient(pdf_service_base_uri, bearer_token));

            // add the GeoCoder Client.

            services.AddTransient<GeocoderClient>(_ => new GeocoderClient(_configuration));

            // add the file manager.
            string fileManagerURI = _configuration["FILE_MANAGER_URI"];
            if (!_env.IsProduction()) // needed for macOS TLS being turned off
            {
                AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            }
            if (!string.IsNullOrEmpty (fileManagerURI))
            {
                var httpClientHandler = new HttpClientHandler();

                if (!_env.IsProduction()) // Ignore certificate errors in non-production modes.  
                                         // This allows you to use OpenShift self-signed certificates for testing.
                {
                    // Return `true` to allow certificates that are untrusted/invalid                    
                    httpClientHandler.ServerCertificateCustomValidationCallback =
                    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                }
                
                var httpClient = new HttpClient(httpClientHandler);
                // set default request version to HTTP 2.  Note that Dotnet Core does not currently respect this setting for all requests.
                httpClient.DefaultRequestVersion = HttpVersion.Version20;
              
                var initialChannel = GrpcChannel.ForAddress(fileManagerURI, new GrpcChannelOptions { HttpClient = httpClient });
                
                var initialClient = new FileManagerClient(initialChannel);
                // call the token service to get a token.
                var tokenRequest = new TokenRequest()
                {
                    Secret = _configuration["FILE_MANAGER_SECRET"]
                };

                var tokenReply = initialClient.GetToken(tokenRequest);

                if (tokenReply != null && tokenReply.ResultStatus == ResultStatus.Success)
                {
                    // Add the bearer token to the client.
                    
                    httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenReply.Token}");

                    var channel = GrpcChannel.ForAddress(fileManagerURI, new GrpcChannelOptions() { HttpClient = httpClient });                   

                    services.AddTransient<FileManagerClient>(_ => new FileManagerClient(channel));

                }
            }

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            var log = loggerFactory.CreateLogger("Startup");

            string connectionString = "unknown.";

#if (USE_MSSQL)

            if (!string.IsNullOrEmpty(Configuration["DB_PASSWORD"]))
            {

                try
                {
                    using (IServiceScope serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
                    {
                        log.LogDebug("Fetching the application's database context ...");
                        AppDbContext context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                        IDynamicsClient dynamicsClient = serviceScope.ServiceProvider.GetService<IDynamicsClient>();

                        connectionString = context.Database.GetDbConnection().ConnectionString;

                        log.LogDebug("Migrating the database ...");
                        context.Database.Migrate();
                        log.LogDebug("The database migration complete.");

                        // run the database seeders
                        log.LogDebug("Adding/Updating seed data ...");

                        Seeders.SeedFactory<AppDbContext> seederFactory = new Seeders.SeedFactory<AppDbContext>(Configuration, env, loggerFactory, dynamicsClient);
                        seederFactory.Seed((AppDbContext)context);
                        log.LogDebug("Seeding operations are complete.");
                    }
                }
                catch (Exception e)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendLine("The database migration failed!");
                    msg.AppendLine("The database may not be available and the application will not function as expected.");
                    msg.AppendLine("Please ensure a database is available and the connection string is correct.");
                    msg.AppendLine("If you are running in a development environment, ensure your test database and server configuration match the project's default connection string.");
                    msg.AppendLine("Which is: " + connectionString);
                    log.LogCritical(new EventId(-1, "Database Migration Failed"), e, msg.ToString());
                }

            }
#else
            // seed for newsletter.

            using (IServiceScope serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                log.LogDebug("Fetching the application's MS Dynamics interface ...");
                IDynamicsClient dynamicsClient = serviceScope.ServiceProvider.GetService<IDynamicsClient>();
                // run the database seeders
                log.LogDebug("Adding/Updating seed data ...");
                Seeders.SeedFactory<AppDbContext> seederFactory = new Seeders.SeedFactory<AppDbContext>(_configuration, env, loggerFactory, dynamicsClient);
                seederFactory.Seed(null);
                log.LogDebug("Seeding operations are complete.");
            }

#endif


            string pathBase = _configuration["BASE_PATH"];

            if (!string.IsNullOrEmpty(pathBase))
            {
                app.UsePathBase(pathBase);
            }
            if (!env.IsProduction())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(errorApp =>
                {
                    errorApp.Run(async context =>
                    {
                        context.Response.StatusCode = 500;
                        context.Response.ContentType = "text/html";

                        await context.Response.WriteAsync("An unexpected server error occurred.\r\n");

                        var exceptionHandlerPathFeature =
                            context.Features.Get<IExceptionHandlerPathFeature>();

                        if (exceptionHandlerPathFeature?.Error != null)
                        {
                            Log.Logger.Error(exceptionHandlerPathFeature?.Error, "Unexpected Error");
                        }
                    });
                });
                app.UseHsts(); // Strict-Transport-Security
                app.UseCors(MyAllowSpecificOrigins);
            }

            var healthCheckOptions = new HealthCheckOptions
            {
                ResponseWriter = async (c, r) =>
                {
                    c.Response.ContentType = MediaTypeNames.Application.Json;
                    var result = JsonConvert.SerializeObject(
                       new
                       {
                           checks = r.Entries.Select(e =>
                      new
                      {
                          description = e.Key,
                          status = e.Value.Status.ToString(),
                          responseTime = e.Value.Duration.TotalMilliseconds
                      }),
                           totalResponseTime = r.TotalDuration.TotalMilliseconds
                       });
                    await c.Response.WriteAsync(result);
                }
            };
            app.UseHealthChecks("/hc/ready", new HealthCheckOptions
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });

            app.UseHealthChecks("/hc/live", new HealthCheckOptions
            {
                // Exclude all checks and return a 200-Ok.
                Predicate = (_) => false
            });

            app.UseXContentTypeOptions();
            app.UseXfo(xfo => xfo.Deny());

            StaticFileOptions staticFileOptions = new StaticFileOptions();

            staticFileOptions.OnPrepareResponse = ctx =>
            {
                ctx.Context.Response.Headers[HeaderNames.CacheControl] = "no-cache, no-store, must-revalidate, private";
                ctx.Context.Response.Headers[HeaderNames.Pragma] = "no-cache";
                ctx.Context.Response.Headers["X-Frame-Options"] = "SAMEORIGIN";
                ctx.Context.Response.Headers["X-XSS-Protection"] = "1; mode=block";
                ctx.Context.Response.Headers["X-Content-Type-Options"] = "nosniff";
            };

            app.UseStaticFiles(staticFileOptions);

            app.UseSpaStaticFiles(staticFileOptions);
            app.UseXXssProtection(options => options.EnabledWithBlockMode());
            app.UseNoCacheHttpHeaders();
            // IMPORTANT: This session call MUST go before UseMvc()
            app.UseSession();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });


            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                // Only run the angular CLI Server in Development mode (not staging or test.)
                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });

            // enable Splunk logger using Serilog
            if (!string.IsNullOrEmpty(_configuration["SPLUNK_COLLECTOR_URL"]) &&
                !string.IsNullOrEmpty(_configuration["SPLUNK_TOKEN"])
                )
            {

                Serilog.Sinks.Splunk.CustomFields fields = new Serilog.Sinks.Splunk.CustomFields();
                if (!string.IsNullOrEmpty (_configuration["SPLUNK_CHANNEL"]))
                {
                    fields.CustomFieldList.Add(new Serilog.Sinks.Splunk.CustomField("channel", _configuration["SPLUNK_CHANNEL"]));
                }
                var splunkUri = new Uri(_configuration["SPLUNK_COLLECTOR_URL"]);
                var upperSplunkHost = splunkUri.Host?.ToUpperInvariant() ?? string.Empty;

                // Fix for bad SSL issues 


                Log.Logger = new LoggerConfiguration()
                    .Enrich.FromLogContext()
                    .Enrich.WithExceptionDetails()
                    .WriteTo.Console()
                    .WriteTo.EventCollector( splunkHost: _configuration["SPLUNK_COLLECTOR_URL"],
                       sourceType: "manual", eventCollectorToken: _configuration["SPLUNK_TOKEN"], 
                       restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information,
#pragma warning disable CA2000 // Dispose objects before losing scope
                       messageHandler: new HttpClientHandler()
                       {
                           ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; }
                       }
#pragma warning restore CA2000 // Dispose objects before losing scope
                     )                    
                    .CreateLogger();

                Serilog.Debugging.SelfLog.Enable(Console.Error);

                Log.Logger.Information("CARLA Portal Container Started");
                
            }
            else
            {
                Log.Logger = new LoggerConfiguration()
                    .Enrich.FromLogContext()
                    .Enrich.WithExceptionDetails()
                    .WriteTo.Console()
                    .CreateLogger();
            }

        }

    }
}
