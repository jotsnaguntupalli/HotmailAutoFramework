using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotmailAutoFramework.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HotmailAutoFramework.Extensions
{
    public static class WebDriverExt
    {
        public static IWebElement WaitTillPageLoads(this IWebDriver driver, By by, int TimeOutInSeconds)
        {
            if (TimeOutInSeconds > 0)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TimeOutInSeconds));
                wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
    }
}
