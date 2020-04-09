using AspNetCore.Mvc.Extensions;
using AspNetCore.Testing.Selenium;
using DND.Web.Areas.Frontend.Controllers.Home.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace DND.UserInterfaceTests
{
    [Collection("DotNetRunFixture")]
    public class SeleniumTests : IDisposable
    {
        private readonly SeleniumChromeBrowserFixture _fixture;
        private readonly SeleniumPage _contactPage;

        public SeleniumTests(DotNetRunFixture dbSetupAndDotNetRun)
        {
            this._fixture = new SeleniumChromeBrowserFixture();
            _contactPage = new SeleniumPage(_fixture.Driver, "en/contact");
        }

        [Fact]
        public void ShouldLoad_SmokeTest()
        {
            var pages = new List<SeleniumPage>();

            pages.Add(new SeleniumPage(_fixture.Driver, "en"));
            pages.Add(new SeleniumPage(_fixture.Driver, "en/blog"));
            pages.Add(new SeleniumPage(_fixture.Driver, "en/gallery"));
            pages.Add(new SeleniumPage(_fixture.Driver, "en/videos"));
            pages.Add(new SeleniumPage(_fixture.Driver, "en/bucket-list"));
            pages.Add(new SeleniumPage(_fixture.Driver, "en/travel-map"));
            pages.Add(new SeleniumPage(_fixture.Driver, "en/about"));
            pages.Add(new SeleniumPage(_fixture.Driver, "en/work-with-me"));
            pages.Add(new SeleniumPage(_fixture.Driver, "en/contact"));

            foreach (var page in pages)
            {
                page.NavigateTo();
            }

            Assert.True(true);
        }

        [Fact]
        public void ShouldValidateContactDetails()
        {
            _contactPage.NavigateTo();

            // Don't enter a name
            _contactPage.EnterFormValue(nameof(ContactViewModel.Email), "test@gmail.com");
            _contactPage.EnterFormValue(nameof(ContactViewModel.Website), "");
            _contactPage.EnterFormValue(nameof(ContactViewModel.Subject), "Enquiry");
            _contactPage.EnterFormValue(nameof(ContactViewModel.Message), "This is a test message");

            var responsePage = _contactPage.Submit("ContactSubmit");

            Assert.Equal("Contact Me | Digital Nomad Dave", _contactPage.Driver.Title);

            IWebElement firstErrorMessage =
                _contactPage.Driver.FindElement(By.Id(nameof(ContactViewModel.Name) + "-error"));

            Assert.Equal("The Name field is required.", firstErrorMessage.Text);
        }

        [Fact]
        public void ShouldSubmitContactDetails()
        {
            _contactPage.NavigateTo();

            _contactPage.EnterFormValue(nameof(ContactViewModel.Name), "James Smith");
            _contactPage.EnterFormValue(nameof(ContactViewModel.Email), "test@gmail.com");
            _contactPage.EnterFormValue(nameof(ContactViewModel.Website), "");
            _contactPage.EnterFormValue(nameof(ContactViewModel.Subject), "Enquiry");
            _contactPage.EnterFormValue(nameof(ContactViewModel.Message), "This is a test message");

            var responsePage = _contactPage.Submit("ContactSubmit");

            Assert.Contains(Messages.MessageSentSuccessfully, responsePage.Html);
        }

        private static void DelayForDemoVideo()
        {
            Thread.Sleep(1000);
        }

        public void Dispose()
        {
            _fixture.Dispose();
        }
    }
}
