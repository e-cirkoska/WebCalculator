using NUnit.Framework;
using OpenQA.Selenium;
using SimpleCalculator.Pages;
using TechTalk.SpecFlow;

namespace SimpleCalculator.AdvancedCalculator
{
    [Binding]
    [TestFixture]
    public sealed class CustomCalculator
    {
        CalculatorPage calculatorPage = new CalculatorPage();
        private readonly IWebDriver driver;

        public CustomCalculator(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"the user enters the number negative 985")]
        public void GivenTheUserEntersTheNumberNegative985()
        {
            calculatorPage.ClickNumber(9, driver);
            calculatorPage.ClickNumber(8, driver);
            calculatorPage.ClickNumber(5, driver);
            calculatorPage.ClickOperationSign("negate", driver);
        }

        [When(@"the user clicks on the X button")]
        public void WhenTheUserClicksOnTheXButton()
        {
            calculatorPage.ClickOperationSign("del2", driver);
        }

        [Then(@"the entry is negative 98")]
        public void ThenTheEntryIsNegative98()
        {
            calculatorPage.CheckResultElementValue("-98", driver);
        }

        [Given(@"the user adds negative 9 and 2 point 5 and pi")]
        public void GivenTheUserAddsNegative9And2Point5AndPi()
        {
            calculatorPage.ClickNumber(9, driver);
            calculatorPage.ClickOperationSign("negate", driver);
            calculatorPage.ClickOperationSign("sum", driver);
            calculatorPage.ClickNumber(2, driver);
            calculatorPage.ClickOperationSign("comma", driver);
            calculatorPage.ClickNumber(5, driver);
            calculatorPage.ClickOperationSign("sum", driver);
            calculatorPage.ClickConstant("pi", driver);
        }

        [Given(@"the user clicks on the CE button")]
        public void GivenTheUserClicksOnTheCEButton()
        {
            calculatorPage.ClickOperationSign("ce", driver);
        }

        [Then(@"the result is 0 point 5")]
        public void ThenTheResultIs0Point5()
        {
            calculatorPage.CheckResultElementValue("0,5", driver);
        }

        [Given(@"the user multiplies 25 by 6 and subtracts 12")]
        public void GivenTheUserMultiplies25By6AndSubtracts12()
        {
            calculatorPage.ClickNumber(2, driver);
            calculatorPage.ClickNumber(5, driver);
            calculatorPage.ClickOperationSign("multiply", driver);
            calculatorPage.ClickNumber(6, driver);
            calculatorPage.ClickOperationSign("substract", driver);
            calculatorPage.ClickNumber(1, driver);
            calculatorPage.ClickNumber(2, driver);
        }

        [Given(@"the user clicks on the C button")]
        public void GivenTheUserClicksOnTheCButton()
        {
            calculatorPage.ClickOperationSign("clear", driver);
        }

        [Then(@"the result is 0")]
        public void ThenTheResultIs0()
        {
            calculatorPage.CheckResultElementValue("0", driver);
        }

        [Then(@"the complete calculation is deleted")]
        public void ThenTheCompleteCalculationIsDeleted()
        {
            calculatorPage.CalcIsEmpty(driver);
        }
    }
}