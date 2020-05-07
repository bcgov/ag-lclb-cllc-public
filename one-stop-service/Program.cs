﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Serilog;
using System;

namespace Gov.Lclb.Cllb.OneStopService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureLogging((hostingContext, logging) =>
            {
                logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                logging.AddConsole(x => x.TimestampFormat = "yyyy-MM-dd HH:mm:ss ");
                logging.AddDebug();
                logging.AddEventSourceLogger();
            })
            .UseSerilog()
            .ConfigureAppConfiguration((hostingContext, config) =>
                    {
                config.AddEnvironmentVariables();
            })
            
            .UseStartup<Startup>();
    }
}
