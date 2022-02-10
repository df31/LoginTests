using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.Extensions.Configuration;

namespace SeleniumTest.Pages
{
    public class SecurePageActions : IDisposable
    {
        private IWebDriver driver;
        private SecurePageObjects securePage;

        public SecurePageActions(IWebDriver driver)
        {
            this.driver = driver;
            securePage = new SecurePageObjects(driver);
        }

        public string GetPageUrl()
        {
            return driver.Url;
        }
        public string GetSuccessMesg()
        {
            return securePage.SuccessMsg.Text;
        }

        public void Dispose()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

    }
}
