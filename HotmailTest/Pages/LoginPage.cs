using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotmailAutoFramework.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace HotmailTest.Pages
{
    public class LoginPage : Basepage
    {
        //PageObjects
        [FindsBy(How = How.Id, Using = "i0116")]
         IWebElement txtUsername { get; set; }

        [FindsBy(How = How.Id, Using = "i0118")]
        IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "idChkBx_PWD_KMSI0Pwd")]
        IWebElement chkSignin { get; set; }

        [FindsBy(How = How.Id, Using = "idSIButton9")]
        IWebElement btnSignin { get; set; }

        public void Login(string userName, string passWord)
        {
            txtUsername.SendKeys(userName);
            txtPassword.SendKeys(passWord);
            chkSignin.Click();
        }

        public InboxPage ClickSignIn()
        {
            btnSignin.Submit();
            return new InboxPage();
        }
    }
    
}
