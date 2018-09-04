namespace SeleniumElementsTest.CustomElements.CustomDropdown
{
    using System.Collections.Generic;
    using System.Linq;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    
    public abstract class BaseCustomDropdown
    {
        protected abstract By DropDownContainerLocator { get; set; }

        protected abstract By DropdownOptionLocator { get; set; }

        protected abstract By ExpandDropdownButtonLocator { get; set; }
        
        public virtual bool IsDropdownDisplayed() => DriverExtensions.WaitForElement(DropDownContainerLocator).Displayed;

        public virtual bool IsDropdownExpanded() => DriverExtensions.WaitForElement(ExpandDropdownButtonLocator).GetAttribute("aria-expanded").Equals("true");

        public virtual List<string> GetAvailableOptions() => this.GetAvailableOptionsElements().Select(o => DriverExtensions.GetHiddentText(o)).ToList();

        public virtual void ToggleDropdown() => DriverExtensions.WaitForElement(ExpandDropdownButtonLocator).Click();

        protected List<IWebElement> GetAvailableOptionsElements() =>
            Driver.Instance.FindElements(new ByChained(DropDownContainerLocator, DropdownOptionLocator)).ToList();

        public virtual void SelectOptionByText(string optionText)
        {
            if (!this.IsDropdownExpanded())
            {
                this.ToggleDropdown();
            }

            this.GetAvailableOptionsElements()
                .FirstOrDefault(o => DriverExtensions.GetHiddentText(o).Contains(optionText))
                .Click();
        }
    }
}
