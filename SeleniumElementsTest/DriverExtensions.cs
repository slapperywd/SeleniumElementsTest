using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SeleniumElementsTest
{
    using OpenQA.Selenium.Support.Extensions;

    public static class DriverExtensions
    {
        private static IWebDriver _driver;
        private static WebDriverWait _wait;

        static DriverExtensions()
        {
            _driver = Driver.Instance;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
        }

        public static IWebElement WaitForElement(params By[] bys) => _wait.Until(d => d.FindElement(new ByChained(bys)));

        public static string GetHiddentText(IWebElement element) => _driver.ExecuteJavaScript<string>("return $(arguments[0]).text();", (object)element);
    }
}
