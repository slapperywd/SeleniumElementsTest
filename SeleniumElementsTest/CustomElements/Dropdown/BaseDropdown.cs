using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumElementsTest
{
    public abstract class BaseDropdown
    {
        protected abstract By DropdownLocator { get; set; }

        private SelectElement DropdownElement => new SelectElement(DriverExtensions.WaitForElement(this.DropdownLocator));

        public virtual List<string> GetAllAvailableOptions() => this.DropdownElement.Options.Select(o => o.Text).ToList();

        public virtual bool IsDropDownDisplayed() => DriverExtensions.WaitForElement(DropdownLocator).Displayed;

        public virtual string GetSelectedOption() => this.DropdownElement.SelectedOption.Text;

        public virtual void SelectOptionByText(string text, bool partialMatch = false) 
            => this.DropdownElement.SelectByText(text, partialMatch);

        public virtual void ToggleDropdown() => DriverExtensions.WaitForElement(DropdownLocator).Click();
    }
}
