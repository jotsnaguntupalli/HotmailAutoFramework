using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotmailAutoFramework.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.PageObjects;
using HotmailAutoFramework.Extensions;

namespace HotmailTest.Pages
{
    public class CommonFunctionalityPage  : Basepage
    {
        //PageObjects
        [FindsBy(How = How.CssSelector, Using = "div._n_a5._n_75")]
         IWebElement btnInbox{ get; set; }

        [FindsBy(How = How.XPath, Using = "((//button[@type='button'])[71])")]
        IWebElement chkMailElement { get; set; }

        [FindsBy(How = How.XPath, Using = "((//button[@type='button'])[39])")]
        IWebElement btnDeletElement { get; set; }

        [FindsBy(How = How.XPath, Using = "((//button[@type='button'])[38])")]
        IWebElement ddlReply { get; set; }

        [FindsBy(How = How.XPath, Using = "((//button[@type='button'])[42])")]
        IWebElement btnArchiveElement { get; set; }

        [FindsBy(How = How.CssSelector, Using = "((//button[@type='button'])[43])")]
        IWebElement btnJunkElement { get; set; }
        

        public void Reply()
        {
            chkMailElement.Click();
        }
        public void Delete()
        {
            btnDeletElement.Click();
        }
        public void Archive()
        {
            btnArchiveElement.Click();
        }
        public void Junk(IWebElement junk)
        {
            btnJunkElement.SelectDropDownList("Junk");
            btnJunkElement.AssertElementPresent();
        }
       
    }
}
