using System;
using OpenQA.Selenium;


namespace SeleniumTest.Pages
{
    public class LoginPageObjects : PageObjectBase
    {
        public IWebElement UsernameBox => WaitForElement(By.Id("username"));
        public IWebElement PasswordBox => WaitForElement(By.Id("password"));
        public IWebElement LoginButton => WaitForElement(By.XPath("//*[@id='login']/button"));
        public IWebElement ErrorMsg => WaitForElement(By.Id("flash"));
        public LoginPageObjects(IWebDriver driver) : base(driver)
        {

        }
    }
}
