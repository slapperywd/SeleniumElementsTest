using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumElementsTest.CustomElements.PanelTab;

namespace SeleniumElementsTest
{
    using SeleniumElementsTest.CustomElements.CustomDropdown;

    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void InitializeTest()
        {
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            driver.Quit();
        }

        private IWebDriver driver = Driver.Instance;

        [TestMethod]
        public void DropDownTest()
        {
                    
            driver.Navigate().GoToUrl("https://www.w3schools.com/howto/howto_custom_select.asp");
            CarDropdown carDropdown = new CarDropdown();
            Console.WriteLine(carDropdown.GetAllAvailableOptions());
            Console.WriteLine(carDropdown.GetSelectedOption());
            Console.WriteLine(carDropdown.IsDropDownDisplayed());
            carDropdown.SelectOptionByText("Audi");
            carDropdown.ToggleDropdown();
            carDropdown.ToggleDropdown();
         
        }

        [TestMethod]
        public void PanelTabTest()
        {
            driver.Navigate().GoToUrl("https://www.w3schools.com/howto/howto_js_tabs.asp");

            JqueryTabPanel jqueryTabPanel = new JqueryTabPanel();
            jqueryTabPanel.ClickTab<ParisTabComponent>(JuqeryPanelTabs.Paris);
        }

        [TestMethod]
        public void CustomDropdownTest()
        {
            driver.Navigate().GoToUrl("https://docs.microsoft.com/en-us/visualstudio/releasenotes/vs2017-relnotes#15.7.6");

            MoreDropdown moreDropdown = new MoreDropdown();
            Console.WriteLine(moreDropdown.IsDropdownDisplayed());
            Console.WriteLine(moreDropdown.GetAvailableOptions());
            moreDropdown.ToggleDropdown();
            moreDropdown.ToggleDropdown();
            moreDropdown.SelectOptionByText("Education");
        }
    }
}
