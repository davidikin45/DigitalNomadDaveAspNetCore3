using AspNetCore.Testing.Selenium;
using TechTalk.SpecFlow;
using Xunit;

namespace DND.UserInterfaceTests
{
    [Binding]
    public class BrowsePagesSteps
    {
        private SeleniumChromeBrowserFixture _browser;
        private SeleniumPage _homeScreen;
        private SeleniumPage _screen;

        [Given(@"I am on the home screen")]
        public void GivenIAmOnTheHomeScreen()
        {
            _browser = new SeleniumChromeBrowserFixture();
            _homeScreen = new SeleniumPage(_browser.Driver, "");
            _homeScreen.NavigateTo();
        }
        
        [When(@"I select the (.*) navigation link")]
        public void WhenISelectTheLink(string link)
        {
            _screen = _homeScreen.ClickLink(link, "nav-link");
        }
        
        [Then(@"I should see the (.*) screen")]
        public void ThenIShouldSeeTheScreen(string title)
        {
            Assert.Equal(title + " | Digital Nomad Dave", _screen.Driver.Title);
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            if(_browser != null)
            {
                _browser.Dispose();
            }
        }
    }
}
