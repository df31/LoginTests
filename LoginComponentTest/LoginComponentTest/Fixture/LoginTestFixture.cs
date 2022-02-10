using System;
using SeleniumTest;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SeleniumTest.Pages;
using OpenQA.Selenium.Support.UI;

namespace LoginComponentTest.Fixture
{
    [Binding]
    public class LoginTestFixture : IDisposable
    {
        public LoginPageActions LoginActions { get; set; }
        public SecurePageActions SecureActions { get; set; }
        private IWebDriver driver = WebDriverFactory.GetChromeDriver();
        public LoginTestFixture()
        {
            LoginActions = new LoginPageActions(driver, Startup.Config);
            SecureActions = new SecurePageActions(driver);
        }

        [Given(@"user typed in (.*) and (.*)")]
        public void GivenUserTypedInAnd(string username, string pwd)
        {
            LoginActions.InputUsername(username);
            LoginActions.InputPassword(pwd);

        }

        [When(@"the credential is submitted")]
        public void WhenTheCredentialIsSubmitted()
        {
            LoginActions.ClickLogin();
            WaitForSeconds(1);
        }

        public void WaitForSeconds(int delay = 5)
        {
            var now = DateTime.Now;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(delay));
            wait.Until(wd => (DateTime.Now - now) - TimeSpan.FromSeconds(delay) > TimeSpan.Zero);
        }
        public void Dispose()
        {
            LoginActions.Dispose();
        }
    }
}
