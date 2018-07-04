using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

using System.Text;
using Newtonsoft.Json;
using System.Net;
using Gov.Lclb.Cllb.Public.Models;
using Gov.Lclb.Cllb.Interfaces.Microsoft.Dynamics.CRM;
using Microsoft.Extensions.DependencyInjection;

namespace Gov.Lclb.Cllb.Public.Test
{
    public class LicenceTypeTests :  ApiIntegrationTestBaseWithLogin
    {
        public LicenceTypeTests(CustomWebApplicationFactory<Startup> factory)
          : base(factory) 
        { }

        const string service = "adoxiolicencetype";

        [Fact]
        public async System.Threading.Tasks.Task TestNoAccessToGetAllByAnonymousUser()
        {
            string id = "SomeRandomId";

            // first confirm we are not logged in
            await GetCurrentUserIsUnauthorized();

            // try a random GET, should return unauthorized
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/" + service );
            var response = await _client.SendAsync(request);
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
            string _discard = await response.Content.ReadAsStringAsync();
        }

        [Fact]
        public async System.Threading.Tasks.Task TestNoAccessToGetByAnonymousUser()
        {
            string id = "SomeRandomId";

            // first confirm we are not logged in
            await GetCurrentUserIsUnauthorized();

            // try a random GET, should return unauthorized
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/" + service + "/" + id);
            var response = await _client.SendAsync(request);
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
            string _discard = await response.Content.ReadAsStringAsync();
        }

        [Fact]
        public async System.Threading.Tasks.Task TestRead()
        {
            
            var loginUser = randomNewUserName("NewLoginUser", 6);
            var strId = await LoginAndRegisterAsNewUser(loginUser);

            
            // R - Read all

            var request = new HttpRequestMessage(HttpMethod.Get, "/api/" + service );
            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
            var licenceTypes = JsonConvert.DeserializeObject<List<ViewModels.AdoxioLicenseType>>(jsonString);
            
            foreach (var licenceType in licenceTypes)
            {
                request = new HttpRequestMessage(HttpMethod.Get, "/api/" + service + "/" + licenceType.id);
                response = await _client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                jsonString = await response.Content.ReadAsStringAsync();
                var licenceTypeData = JsonConvert.DeserializeObject<ViewModels.AdoxioLicenseType>(jsonString);

                // verify that we got the same data back.
                Assert.Equal(licenceType.id, licenceTypeData.id);
                Assert.Equal(licenceType.name, licenceTypeData.name);
                Assert.Equal(licenceType.code, licenceTypeData.code);

            }

            await LogoutAndCleanupTestUser(strId);

        }


        [Fact]
        public async System.Threading.Tasks.Task Test404onInvalidId()
        {
            string badId = "BadId";

            var loginUser = randomNewUserName("NewLoginUser", 6);
            var strId = await LoginAndRegisterAsNewUser(loginUser);
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/" + service + "/" + badId);
            var response = await _client.SendAsync(request);
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

            await LogoutAndCleanupTestUser(strId);
        }
    }
}
