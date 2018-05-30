using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumElementsTest
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver = Driver.Instance;

        [TestMethod]
        public void TestMethod1()
        {
            driver.Manage().Window.Maximize();
          
            driver.Navigate().GoToUrl("https://www.w3schools.com/howto/howto_custom_select.asp");
            CarDropdown carDropdown = new CarDropdown();
            Console.WriteLine(carDropdown.GetSelectedOption());
            Console.WriteLine(carDropdown.IsDropDownDisplayed());
            carDropdown.SelectOptionByText("Audi");

            driver.Quit();
        }
    }
}
