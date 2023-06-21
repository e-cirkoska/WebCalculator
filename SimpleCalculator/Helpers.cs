using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Linq;
using OpenQA.Selenium.Support.UI;

namespace ExecutableSpecifications.Helpers
{
    public sealed class Helpers
    {
        public void Click(By selector, IWebDriver driver)
        {
            try
            {
                driver.FindElement(selector).Click();
            }
            catch (Exception e)
            {
                throw new Exception(e + "\n Selector: " + selector);
            }
        }
    }
}