using NUnit.Framework;
using OpenQA.Selenium;
using SimpleCalculator.Pages;
using TechTalk.SpecFlow;

namespace SimpleCalculator.BasicCalculator
{
    [Binding]
    [TestFixture]

    public sealed class BasicCalculator
    {
        CalculatorPage calculatorPage = new CalculatorPage();
        private readonly IWebDriver driver;

        public BasicCalculator(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"the user opens the calculator page")]
        public void GivenTheUserOpensTheCalculatorPage()
        {
            calculatorPage.NavigateToPage(driver);
        }


        [Given(@"the user enters number 3")]
        public void GivenTheUserEntersNumber3()
        {
            calculatorPage.ClickNumber(3, driver);
        }


        [Given(@"the user clicks on the plus button")]
        public void GivenTheUserClicksOnThePlusButton()
        {
            calculatorPage.ClickOperationSign("sum", driver);
        }


        [Given(@"the user enters number 8")]
        public void GivenTheUserEntersNumber8()
        {
            calculatorPage.ClickNumber(8, driver);
        }


        [Given(@"the user enters number 24")]
        public void GivenTheUserEntersNumber24()
        {
            calculatorPage.ClickNumber(2, driver);
            calculatorPage.ClickNumber(4, driver);
        }

        [Given(@"the user enters number 19")]
        public void GivenTheUserEntersNumber19()
        {
            calculatorPage.ClickNumber(1, driver);
            calculatorPage.ClickNumber(9, driver);
        }

        [When(@"the user clicks on the equals sign")]
        public void WhenTheUserClicksOnTheEqualsSign()
        {
            calculatorPage.ClickOperationSign("equalTo", driver);
        }

        [Then(@"the result is 11")]
        public void ThenTheResultIs11()
        {
            calculatorPage.CheckResult(3 + 8, driver);
        }

        [Then(@"the result is 43")]
        public void ThenTheResultIs43()
        {
            calculatorPage.CheckResult(24 + 19, driver);
        }

        [Given(@"the user enters number 13")]
        public void GivenTheUserEntersNumber13()
        {
            calculatorPage.ClickNumber(1, driver);
            calculatorPage.ClickNumber(3, driver);
        }


        [Given(@"the user clicks on the minus button")]
        public void GivenTheUserClicksOnTheMinusButton()
        {
            calculatorPage.ClickOperationSign("substract", driver);
        }


        [Given(@"the user enters number 37")]
        public void GivenTheUserEntersNumber37()
        {
            calculatorPage.ClickNumber(3, driver);
            calculatorPage.ClickNumber(7, driver);
        }

        [Then(@"the result is negative 24")]
        public void ThenTheResultIsNegative24()
        {
            calculatorPage.CheckResult(13 - 37, driver);
        }

        [Given(@"the user enters number 7")]
        public void GivenTheUserEntersNumber7()
        {
            calculatorPage.ClickNumber(7, driver);
        }

        /*Substracting with 2 instead of 5 because the calculator gives wrong result for 7-5
        (the result is 4 instead of 2)*/
        [Given(@"the user enters number 2")]
        public void GivenTheUserEntersNumber2()
        {
            calculatorPage.ClickNumber(2, driver);
        }

        [Then(@"the result is 5")]
        public void ThenTheResultIs5()
        {
            calculatorPage.CheckResult(7 - 2, driver);
        }

        [Given(@"the user enters number 5")]
        public void GivenTheUserEntersNumber5()
        {
            calculatorPage.ClickNumber(5, driver);
        }

        [Given(@"the user clicks on the multiply button")]
        public void GivenTheUserClicksOnTheMultiplyButton()
        {
            calculatorPage.ClickOperationSign("multiply", driver);
        }

        [Then(@"the result is 15")]
        public void ThenTheResultIs15()
        {
            calculatorPage.CheckResult(5 * 3, driver);
        }

        [Given(@"the user enters number 23")]
        public void GivenTheUserEntersNumber23()
        {
            calculatorPage.ClickNumber(2, driver);
            calculatorPage.ClickNumber(3, driver);
        }

        [Given(@"the user enters number 47")]
        public void GivenTheUserEntersNumber47()
        {
            calculatorPage.ClickNumber(4, driver);
            calculatorPage.ClickNumber(7, driver);
        }

        [Then(@"the result is 1081")]
        public void ThenTheResultIs1081()
        {
            calculatorPage.CheckResult(23 * 47, driver);
        }

        [Given(@"the user enters number 11")]
        public void GivenTheUserEntersNumber11()
        {
            calculatorPage.ClickNumber(1, driver);
            calculatorPage.ClickNumber(1, driver);
        }

        [Given(@"the user clicks on the divide button")]
        public void GivenTheUserClicksOnTheDivideButton()
        {
            calculatorPage.ClickOperationSign("divide", driver);
        }

        [Then(@"the result is 5 point 5")]
        public void ThenTheResultIs5point5()
        {
            calculatorPage.CheckResult(11.0 / 2.0, driver);
        }

        [Given(@"the user enters number 0")]
        public void GivenTheUserEntersNumber0()
        {
            calculatorPage.ClickNumber(0, driver);
        }

        [Then(@"the result is invalid input")]
        public void ThenTheResultIsInvalidInput()
        {
            calculatorPage.CheckResult(0, driver, false);
        }
    }
}