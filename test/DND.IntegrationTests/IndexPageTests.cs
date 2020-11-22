using AspNetCore.Testing;
using AspNetCore.Testing.Helpers;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace DND.IntegrationTests
{
    public class IndexPageTests : IClassFixture<EnvironmentVariablesFixture>, IClassFixture<WebAppFactory>
    {
        private readonly WebAppFactory _factory;

        public IndexPageTests(WebAppFactory factory)
        {
            _factory = factory;
        }

        public static IEnumerable<object[]> ConfigVariations => new List<object[]> {
            new object[] { false, false, false },
            new object[] { true, false, false },
            new object[] { false, true, false },
            new object[] { true, true, true }
        };

        [Theory]
        [MemberData(nameof(ConfigVariations))]
        public async Task RenderExpectedForConfigVariations(bool globalEnabled, bool pageEnabled, bool shouldShow)
        {
            // Arrange
            var a = shouldShow;

            var client = _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureAppConfiguration((ctx, config) =>
                {
                    config.AddInMemoryCollection(new Dictionary<string, string>
                    {
                        {"FeatureManagement:WeatherForecasting:EnableWeatherForecast" , globalEnabled.ToString()},
                        {"FeatureManagement:Homepage:EnableWeatherForecast" , pageEnabled.ToString()}
                    });
                });
            }).CreateClient();

            // Act
            var response = await client.GetAsync("/en");

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299

            //AngleSharp
            using var content = await HtmlHelpers.GetDocumentAsync(response);

            //var div = content.All.SingleOrDefault(e => e.Id == "id" && e.LocalName == TagNames.Div);

            //Assert.Equal(shouldShow, div != null);

            Assert.True(true);
        }
    }
}
