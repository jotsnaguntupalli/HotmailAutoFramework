using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace HotmailAutoFramework.Core
{
    public abstract class Basepage
    {
        public Basepage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
    }
}
