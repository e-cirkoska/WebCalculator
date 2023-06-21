using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

public static class WebDriverFactory
{
    public static IWebDriver CreateWebDriver()
    {
        string browser = ConfigurationManager.AppSettings["Browser"]?.ToLower();

        if (browser == "chrome")
        {
            ChromeOptions options = new ChromeOptions();
            return new ChromeDriver(options);
        }
        else if (browser == "firefox")
        {
            FirefoxOptions options = new FirefoxOptions();
            return new FirefoxDriver(options);
        }
        else if (browser == "edge")
        {
            EdgeOptions options = new EdgeOptions();
            return new EdgeDriver(options);
        }
        else
        {
            throw new ArgumentException("Invalid browser selection in configuration file.");
        }
    }
}