using NUnit.Framework;
using OpenQA.Selenium;
using SimpleCalculator.Pages;
using System;
using TechTalk.SpecFlow;

namespace SimpleCalculator.AdvancedCalculator
{
    [Binding]
    [TestFixture]
    public sealed class AdvancedCalculator
    {
        CalculatorPage calculatorPage = new CalculatorPage();
        private readonly IWebDriver driver;


        public AdvancedCalculator(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"the user enters the number 324")]
        public void GivenTheUserEntersTheNumber324()
        {
            calculatorPage.ClickNumber(3, driver);
            calculatorPage.ClickNumber(2, driver);
            calculatorPage.ClickNumber(4, driver);
        }

        [When(@"the user clicks on the square root button")]
        public void WhenTheUserClicksOnTheSquareRootButton()
        {
            calculatorPage.ClickOperationSign("squareRoot", driver);
        }

        [Then(@"the result is 18")]
        public void ThenTheResultIs18()
        {
            calculatorPage.CheckResult(Math.Sqrt(324), driver);
        }

        [Given(@"the user enters the number 23")]
        public void GivenTheUserEntersTheNumber23()
        {
            calculatorPage.ClickNumber(2, driver);
            calculatorPage.ClickNumber(3, driver);
        }

        [When(@"the user clicks on the square power button")]
        public void WhenTheUserClicksOnTheSquarePowerButton()
        {
            calculatorPage.ClickOperationSign("squarePower", driver);
        }

        [Then(@"the result is 529")]
        public void ThenTheResultIs529()
        {
            calculatorPage.CheckResult(Math.Pow(23, 2), driver);
        }

        [Given(@"the user enters the number 2744")]
        public void GivenTheUserEntersTheNumber2744()
        {
            calculatorPage.ClickNumber(2, driver);
            calculatorPage.ClickNumber(7, driver);
            calculatorPage.ClickNumber(4, driver);
            calculatorPage.ClickNumber(4, driver);
        }

        [When(@"the user clicks on the cube root button")]
        public void WhenTheUserClicksOnTheCubeRootButton()
        {
            calculatorPage.ClickOperationSign("cubeRoot", driver);
        }

        [Then(@"the result is 14")]
        public void ThenTheResultIs14()
        {
            calculatorPage.CheckResult(Math.Pow(2744, 1.0 / 3.0), driver);
        }

        [Given(@"the user enters the number 8")]
        public void GivenTheUserEntersTheNumber8()
        {
            calculatorPage.ClickNumber(8, driver);
        }

        [When(@"the user clicks on the inverse button")]
        public void WhenTheUserClicksOnTheInverseButton()
        {
            calculatorPage.ClickOperationSign("overX", driver);
        }

        [Then(@"the result is 0 point 125")]
        public void ThenTheResultIs0point125()
        {
            calculatorPage.CheckResult(1.0 / 8.0, driver);
        }

        [Given(@"the user enters the number 7")]
        public void GivenTheUserEntersTheNumber7()
        {
            calculatorPage.ClickNumber(7, driver);
        }

        [When(@"the user clicks on the factorial button")]
        public void WhenTheUserClicksOnTheFactorialButton()
        {
            calculatorPage.ClickOperationSign("factorial", driver);
        }

        int CalculateFactorial(int number)
        {
            int factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        [Then(@"the result is 5040")]
        public void ThenTheResultIs()
        {
            calculatorPage.CheckResult(CalculateFactorial(7), driver);
        }

        [Given(@"the user enters the number 0")]
        public void GivenTheUserEntersTheNumber()
        {
            calculatorPage.ClickNumber(0, driver);
        }

        [Then(@"the result is 1")]
        public void ThenTheResultIs1()
        {
            calculatorPage.CheckResult(CalculateFactorial(0), driver);
        }

        [When(@"the user clicks on the e constant button")]
        public void WhenTheUserClicksOnTheEConstantButton()
        {
            calculatorPage.ClickConstant("e", driver);
        }

        [Then(@"the result up to the 9th decimal point is correct")]
        public void ThenTheResultUpToThe9ThDecimalPointIsCorrect()
        {
            calculatorPage.CheckResultDecimals("2,718281828", 11, driver);
        }

        [When(@"the user clicks on the pi constant button")]
        public void WhenTheUserClicksOnThePiConstantButton()
        {
            calculatorPage.ClickConstant("pi", driver);
        }

        [Then(@"the result up to the 14th decimal point is correct")]
        public void ThenTheResultUpToThe14ThDecimalPointIsCorrect()
        {
            calculatorPage.CheckResultDecimals("3,14159265358979", 16, driver);
        }
    }
}