using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.Extensions.Configuration;

namespace SeleniumTest.Pages
{
    public class LoginPageActions : IDisposable
    {
        private IWebDriver driver;
        private LoginPageObjects loginPage;

        public LoginPageActions(IWebDriver driver, IConfiguration config)
        {
            this.driver = driver;
            driver.Url = config["LoginPage:Url"];
            loginPage = new LoginPageObjects(driver);
        }
        public void InputUsername(string username)
        {
            loginPage.UsernameBox.SendKeys(username);
        }
        public void InputPassword(string passwd)
        {
            loginPage.PasswordBox.SendKeys(passwd);
        }
        public void ClickLogin()
        {
            loginPage.LoginButton.Click();
        }
        public string GetErrorMsg()
        {
            return loginPage.ErrorMsg.Text;
        }

        public void Dispose()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}
