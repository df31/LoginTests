using System;
using OpenQA.Selenium;

namespace SeleniumTest.Pages
{
    public class SecurePageObjects :PageObjectBase
    {
        public IWebElement SuccessMsg => WaitForElement(By.Id("flash"));
        public SecurePageObjects(IWebDriver driver) : base(driver)
        {

        }
    }
}
