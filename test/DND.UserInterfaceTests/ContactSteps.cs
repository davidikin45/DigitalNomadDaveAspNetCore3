using AspNetCore.Mvc.Extensions;
using AspNetCore.Testing.Selenium;
using DND.Web.Areas.Frontend.Controllers.Home.Models;
using OpenQA.Selenium;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

//Features run in parallel. To disable put this in AssemblyInfo.cs
//[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace DND.UserInterfaceTests
{
    [Binding]
    public class ContactSteps
    {
        private SeleniumChromeBrowserFixture _browser;
        private SeleniumPage _contactScreen;
        private SeleniumPage _responseScreen;

        [Given(@"I am on the contact screen")]
        public void GivenIAmOnTheContactScreen()
        {
            _browser = new SeleniumChromeBrowserFixture();
            _contactScreen = new SeleniumPage(_browser.Driver, "contact");
            _contactScreen.NavigateTo();
        }

        [Given(@"I enter the following values")]
        public void GivenIEnterTheFollowingValues(Table table)
        {
           var nameRow = table.Rows.FirstOrDefault(row => row["field"] == nameof(ContactViewModel.Name));
           var emailRow = table.Rows.FirstOrDefault(row => row["field"] == nameof(ContactViewModel.Email));
           var subjectRow = table.Rows.FirstOrDefault(row => row["field"] == nameof(ContactViewModel.Subject));
           var messageRow = table.Rows.FirstOrDefault(row => row["field"] == nameof(ContactViewModel.Message));

            dynamic attributes = table.CreateDynamicSet();

            if (nameRow != null)
            {
                GivenIEnterNameOf(nameRow["value"]);
            }

            if (emailRow != null)
            {
                GivenIEnterEmailOf(nameRow["value"]);
            }

            if (subjectRow != null)
            {
                GivenIEnterSubjectAs(nameRow["value"]);
            }

            if (messageRow != null)
            {
                GivenIEnterMesageAs(nameRow["value"]);
            }
        }


        [Given(@"I enter name of (.*)")]
        public void GivenIEnterNameOf(string name)
        {
            _contactScreen.EnterFormValue(nameof(ContactViewModel.Name), name);
        }
        
        [Given(@"I enter email of (.*)")]
        public void GivenIEnterEmailOf(string email)
        {
            _contactScreen.EnterFormValue(nameof(ContactViewModel.Email), email);
        }
        
        [Given(@"I enter subject as (.*)")]
        public void GivenIEnterSubjectAs(string subject)
        {
            _contactScreen.EnterFormValue(nameof(ContactViewModel.Subject), subject);
        }
        
        [Given(@"I enter mesage as (.*)")]
        public void GivenIEnterMesageAs(string message)
        {
            _contactScreen.EnterFormValue(nameof(ContactViewModel.Message), message);
        }
        
        [When(@"I submit the contact form")]
        public void WhenISubmitTheContactForm()
        {
            _responseScreen = _contactScreen.Submit("ContactSubmit");
        }
        
        [Then(@"I should see the confirmation message")]
        public void ThenIShouldSeeTheConfirmation()
        {
            Assert.Contains(Messages.MessageSentSuccessfully, _responseScreen.Html);
        }

        [Then(@"I should see an error message telling me the Name field is required")]
        public void ThenIShouldSeeAnErrorMessageTellingMeTheNameFieldIsRequired()
        {
            IWebElement firstErrorMessage =
                _responseScreen.Driver.FindElement(By.Id(nameof(ContactViewModel.Name) + "-error"));

            Assert.Equal("The Name field is required.", firstErrorMessage.Text);
        }


        [AfterScenario]
        public void DisposeWebDriver()
        {
            if (_browser != null)
            {
                _browser.Dispose();
            }
        }
    }
}
