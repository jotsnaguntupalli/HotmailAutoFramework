using System;
using HotmailAutoFramework.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace HotmailTest.Tests
{
    [TestClass]
    public class LoginTest : Base
    {
        private string url = "https://www.hotmail.com";
        private IWebDriver _driver;
        [TestMethod]
        public void TestMethod1()
        {
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();

        }
    }
}
