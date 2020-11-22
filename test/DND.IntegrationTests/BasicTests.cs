using AspNetCore.Mvc.Extensions;
using AspNetCore.Testing;
using AspNetCore.Testing.Extensions;
using AspNetCore.Testing.Helpers;
using AspNetCore.Testing.TestServer;
using DND.Data;
using DND.Web.Areas.Frontend.Controllers.Home.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Xunit;

namespace DND.IntegrationTests
{
    public class BasicTests : IClassFixture<EnvironmentVariablesFixture>, IClassFixture<WebAppFactory>
    {
        private readonly WebAppFactory _factory;

        public BasicTests(WebAppFactory factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/en")]
        [InlineData("/en/blog")]
        [InlineData("/en/gallery")]
        [InlineData("/en/videos")]
        [InlineData("/en/countries")]
        [InlineData("/en/locations")]
        [InlineData("/en/bucket-list")]
        [InlineData("/en/travel-map")]
        [InlineData("/en/about")]
        [InlineData("/en/work-with-me")]
        [InlineData("/en/contact")]
        public async Task RenderPageSuccessfully(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            //var client = _factory.WithWebHostBuilder(builder =>
            //{
            //    builder.ConfigureTestServices(services =>
            //    {
            //        //Add fake (In memory) vs mock (register calls without testing)
            //        //Initialise Db
            //    });
            //}).CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299

            //AngleSharp
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            var content = await HtmlHelpers.GetDocumentAsync(response);
#pragma warning restore IDE0059 // Unnecessary assignment of a value

            Assert.Equal("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }

        [Fact]
        public async Task GetAllPublicRoutesAndRenderPagesSuccessfully()
        {
            // Arrange
            var client = _factory.CreateClient();

            var routeInfo = _factory.GetAllRoutes();

            var testRoutes = new List<string>();
            foreach (var action in routeInfo.Actions)
            {
                string path = action.Path;

                IEnumerable<string> httpMethods = action.HttpMethods;
                bool authorized = action.Authorized;

                if (!authorized && path != null && (httpMethods == null || httpMethods.ToList().Contains(HttpMethod.Get.Method)))
                {
                    testRoutes.Add(path);
                }
            }

            foreach (var route in testRoutes)
            {
                var testRoute = route.Replace("{culture:cultureCheck}", "en");
                if (!testRoute.Contains("{") && !testRoute.Contains("api") && !testRoute.Contains("AccessDenied") && !testRoute.Contains("Account") && !testRoute.Contains("Manage"))
                {
                    var response = await client.GetAsync(testRoute);
                    Assert.NotEqual(HttpStatusCode.InternalServerError, response.StatusCode);
                }
            }

            Assert.True(true);
        }
    }
}
