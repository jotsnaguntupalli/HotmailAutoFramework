using System;
using HotmailAutoFramework.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace HotmailAutoFramework.Core
{
    public class Base
    {
        private IWebDriver _driver = null;

        public static Basepage CurrentPage { get; set; }

        protected TPage GetInstance<TPage>() where TPage : Basepage, new()
        {
            TPage pageInstance = new TPage
            {
               _driver = Driver.driver
            };
            return pageInstance;
        }

        public TPage As<TPage>() where TPage : Basepage
        {
            return (TPage) this;
        }

    }
}