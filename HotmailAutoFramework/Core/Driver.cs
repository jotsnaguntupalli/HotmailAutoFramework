using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HotmailAutoFramework.Core
{
    public static class Driver
    {
        public static IWebDriver driver { get; set; }

        public static Browser Browser { get; set; }
    }
}
