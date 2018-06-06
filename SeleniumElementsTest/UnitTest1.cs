using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumElementsTest.CustomElements.PanelTab;

namespace SeleniumElementsTest
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver = Driver.Instance;

        [TestMethod]
        public void TestDropDown()
        {
            driver.Manage().Window.Maximize();
          
            driver.Navigate().GoToUrl("https://www.w3schools.com/howto/howto_custom_select.asp");
            CarDropdown carDropdown = new CarDropdown();
            Console.WriteLine(carDropdown.GetSelectedOption());
            Console.WriteLine(carDropdown.IsDropDownDisplayed());
            carDropdown.SelectOptionByText("Audi");

            driver.Quit();
        }

        [TestMethod]
        public void TestPanelTab()
        {
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.w3schools.com/howto/howto_js_tabs.asp");

            JqueryTabPanel jqueryTabPanel = new JqueryTabPanel();
            jqueryTabPanel.ClickTab<ParisTabComponent>(JuqeryPanelTabs.Paris);

            driver.Quit();
        }
    }
}
