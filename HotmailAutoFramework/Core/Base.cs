using System;
using HotmailAutoFramework.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;


namespace HotmailAutoFramework.Core
{
    public class Base

    {
        private IWebDriver driver;
        public static Basepage Currentpage { get; set; }

        protected TPage GetInstance<TPage>() where TPage : Basepage, new()
        {
            TPage pageInstance = new TPage
            {
                driver = Driver.driver
            };
            return pageInstance;
        }

        public TPage As<TPage>() where TPage : Basepage
        {
            return (TPage) this;
        }
    }
    
}