using BoDi;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SimpleCalculator
{
    [Binding]
    public class SpecFlowHooks
    {
        private readonly IObjectContainer container;

        public SpecFlowHooks(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeScenario]
        public void CreateWebDriver()
        {
            IWebDriver driver = WebDriverFactory.CreateWebDriver();
            container.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void DestroyWebDriver(IWebDriver driver)
        {
            driver.Quit();
        }
    }
 }
