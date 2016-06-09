using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotmailAutoFramework.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace HotmailAutoFramework.Extensions
{
    public static  class WebElementExt
    {
        public static  void SelectDropDownList(this IWebElement element, string value)
        {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByText(value);
        }

        public static string GetDropDownOptions(this IWebElement element)
        {
            SelectElement selectElement = new SelectElement(element);
            return selectElement.AllSelectedOptions.First().ToString();
        }

        public static IList<IWebElement> GetAllDropDownOptions(this IWebElement element)
        {
            SelectElement selectElement = new SelectElement(element);
            return selectElement.AllSelectedOptions;
        }

        public static void AssertElementPresent(this IWebElement element)
        {
            if(!IsElementPresent(element))
                throw new Exception("Element not present");
        }

        private static bool IsElementPresent(IWebElement element)
        {
            try
            {
                bool ele = element.Displayed;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static void MouseHover(this IWebElement element)
        {
            Actions actionHover = new Actions(Driver.driver);
            actionHover.MoveToElement(element).Click();
        }

        public static void DoubleClick(this IWebElement element)
        {
            Actions actionDoubleClick = new Actions(Driver.driver);
            actionDoubleClick.DoubleClick();
        }

        public static void ScreenShot(this IWebElement element)
        {
            ITakesScreenshot screenShotDriver = Driver.driver as ITakesScreenshot;
                       Screenshot screenShot = screenShotDriver.GetScreenshot();
            screenShot.SaveAsFile(@"c:\save.bmp", ImageFormat.Bmp);
        }

        public static void DragDrop(this IWebElement sourceElement, IWebElement targetElement)
        {
            Actions actionDragDrop = new Actions(Driver.driver);
            actionDragDrop.DragAndDrop(sourceElement, targetElement);
        }

        public static void Scroll(this IWebElement element)
        {
            IJavaScriptExecutor javaExecutor = (IJavaScriptExecutor)Driver.driver;
            javaExecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150");
        }
    }
}
