using AspNetCore.Mvc.Extensions;
using AspNetCore.Testing;
using AspNetCore.Testing.TestServer;
using DND.Web.Areas.Frontend.Controllers.Home.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace DND.IntegrationTests
{
    public class ContactFormTests : IClassFixture<EnvironmentVariablesFixture>, IClassFixture<WebAppFactory>
    {
        private readonly WebAppFactory _factory;

        public ContactFormTests(WebAppFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task AcceptContactFormPost()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Get initial response that contains anti forgery tokens
            HttpResponseMessage initialResponse = await client.GetAsync("/en/contact");
            var (fieldValue, cookieValue) = await _factory.ExtractAntiForgeryValues(initialResponse);

            // Create POST request, adding anti forgery cookie and form field
            HttpRequestMessage postRequest = new HttpRequestMessage(HttpMethod.Post, "/en/contact");

            postRequest.Headers.Add("Cookie", $"{TestServerFixtureBase<object>.AntiForgeryCookieName}={cookieValue}");

            var formData = new Dictionary<string, string>
            {
                {TestServerFixtureBase<object>.AntiForgeryFieldName, fieldValue},
                {nameof(ContactViewModel.Name),"James Smith"},
                {nameof(ContactViewModel.Email),"test@gmail.com"},
                {nameof(ContactViewModel.Website),""},
                {nameof(ContactViewModel.Subject),"Enquiry"},
                {nameof(ContactViewModel.Message),"This is a test message"}
            };

            postRequest.Content = new FormUrlEncodedContent(formData);

            HttpResponseMessage postResponse = await client.SendAsync(postRequest);

            postResponse.EnsureSuccessStatusCode();

            var responseString = await postResponse.Content.ReadAsStringAsync();

            Assert.Contains(Messages.MessageSentSuccessfully, responseString);
        }
    }
}
