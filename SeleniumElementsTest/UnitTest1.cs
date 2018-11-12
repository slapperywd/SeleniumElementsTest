using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumElementsTest.CustomElements.PanelTab;

namespace SeleniumElementsTest
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    using SeleniumElementsTest.CustomElements;
    using SeleniumElementsTest.CustomElements.Buttons;
    using SeleniumElementsTest.CustomElements.CustomDropdown;
    using SeleniumElementsTest.CustomElements.List;

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

        [TestMethod]
        public void ButtonElementTest()
        {
            driver.Navigate().GoToUrl("https://developer.mozilla.org/en-US/docs/Learn/Server-side/Express_Nodejs/deployment");
            var button = new Button(By.XPath("(//a[contains(.,'Previous')])[1]"));
            
            button.Click();
            Thread.Sleep(3500);
        }

        [TestMethod]
        public void ListElementTest()
        {
            driver.Navigate().GoToUrl("https://developer.mozilla.org/en-US/docs/Learn/Server-side/Express_Nodejs/deployment");
            var anchorsList = new ListElement(By.XPath("//a[@class='local-anchor']"));

            anchorsList.GetItems().ForEach(anchor => anchor.Click());

            Thread.Sleep(3500);
        }

        [TestMethod]
        public void ListElementGenericTest()
        {
            driver.Navigate().GoToUrl("https://github.com/slapperywd?tab=repositories");

            var repoList = new ListElementGeneric<GitHubRepositoryItem>(By.XPath("//ul[@data-filterable-for='your-repos-filter']/li"));
            var repoListItems = repoList.GetItems();

            foreach (var repo in repoListItems)
            {
                Console.WriteLine($"Repo name {repo.RepositoryName}");
                Console.WriteLine($"Repo description {repo.Description}");
                Console.WriteLine($"Programming language {repo.ProgrammingLanguage}");
                Console.WriteLine($"Date {repo.Date}");
                Console.WriteLine();
            }

            repoListItems.First().ClickRepositoryLink();

            //Thread.Sleep(3500);
        }
    }
}
