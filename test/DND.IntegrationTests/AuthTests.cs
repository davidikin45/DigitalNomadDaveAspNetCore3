using AspNetCore.Testing;
using AspNetCore.Testing.Extensions;
using DND.Data;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Xunit;

namespace DND.IntegrationTests
{
    public class AuthTests : IClassFixture<EnvironmentVariablesFixture>, IClassFixture<WebAppFactory>
    {
        private readonly WebAppFactory _factory;

        public AuthTests(WebAppFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get_SecurePageRedirectsAnUnauthenticatedUser()
        {
            var client = _factory.WithWebHostBuilder(builder =>
            {
                builder.WithDb<AppContext>((sp, db) => {


                });
            }).CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false,
            });

            var response = await client.GetAsync("/en/admin");

            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
            Assert.StartsWith("http://localhost/Account/Login",
                response.Headers.Location.OriginalString);
        }

        public static IEnumerable<object[]> RoleAccess => new List<object[]>
        {
            new object[] { "member", HttpStatusCode.Forbidden },
            new object[] { "admin", HttpStatusCode.OK }
        };

        [Theory]
        [MemberData(nameof(RoleAccess))]
        public async Task Get_SecurePageAccessibleOnlyByAdminUsers(string role, HttpStatusCode expected)
        {
            var client = _factory.WithWebHostBuilder(builder =>
            {
                builder.WithUserInRole(role).WithDb<AppContext>((sp, db) => { 

            
                });
            }).CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false,
            });

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Test");

            //Secured Page
            var response = await client.GetAsync("/en/admin");

            Assert.Equal(expected, response.StatusCode);
        }
    }
}
