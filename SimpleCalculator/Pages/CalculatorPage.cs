using ExecutableSpecifications.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Configuration;


namespace SimpleCalculator.Pages
{
    public sealed class CalculatorPage
    {
        Helpers helpers = new Helpers();
        By mainNum = By.XPath("//*[@id='nums-bottom']");
        By topNum = By.XPath("//*[@id='nums-top']");


        public void NavigateToPage(IWebDriver driver)
        {
            string url = ConfigurationManager.AppSettings["BaseUrl"];
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
        }


        public void ClickNumber(int number, IWebDriver driver)
        {
            By numberLocator;
            if ($"{number}".Length == 1) { numberLocator = By.Id($"num{number}"); }
            else { throw new InvalidSelectorException("Invalid number"); }

            helpers.Click(numberLocator, driver);
        }

        public void ClickConstant(string constant, IWebDriver driver)
        {
            By constLocator;

            if (constant == "pi")
            {
                constLocator = By.Id("pi");
            }
            else if (constant == "e")
            {
                constLocator = By.Id("euler");
            }
            else
            {
                throw new InvalidSelectorException("Invalid constant");
            }

            helpers.Click(constLocator, driver);
        }

        public void ClickOperationSign(string operation, IWebDriver driver)
        {
            By operationLocator;
            operationLocator = By.Id($"{operation}");

            helpers.Click(operationLocator, driver);
        }

        public void CheckResult(double expected, IWebDriver driver, bool isValidInput = true)
        {
            try
            {
                string actual = driver.FindElement(mainNum).Text;
                if (isValidInput == true)
                {
                    Assert.AreEqual(expected.ToString().Replace('.', ','), actual);
                }
                else { Assert.AreEqual("Invalid input", actual); }
            }
            catch (Exception e)
            {
                throw new Exception(e + "\n Selector: " + mainNum);
            }
        }


        public void CheckResultDecimals(string expected, int numOfChars, IWebDriver driver)
        {
            {
                try
                {
                    string actual = driver.FindElement(mainNum).Text;
                    string first14Decimals = actual.Substring(0, Math.Min(actual.Length, numOfChars));

                    Assert.AreEqual(expected, first14Decimals);
                }
                catch (Exception e)
                {
                    throw new Exception(e + "\n Selector: " + mainNum);
                }
            }
        }
        public void CheckResultElementValue(string expected, IWebDriver driver)
        {
            try
            {
                string actual = driver.FindElement(mainNum).Text;

                Assert.AreEqual(expected, actual);
            }
            catch (Exception e)
            {
                throw new Exception(e + "\n Selector: " + mainNum);
            }
        }

        public void CalcIsEmpty(IWebDriver driver)
        {
            Assert.IsEmpty(driver.FindElement(topNum).Text);
        }
    }
}
