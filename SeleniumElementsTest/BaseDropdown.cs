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

        protected SelectElement DropdownElement => new SelectElement(DriverExtensions.WaitForElement(DropdownLocator));

        protected virtual List<string> GetAllAvailableOptions() 
            => Driver.Instance.FindElements(DropdownLocator).Select(o => o.Text).ToList();

        public virtual bool IsDropDownDisplayed() => DriverExtensions.WaitForElement(DropdownLocator).Displayed;

        public virtual string GetSelectedOption() => this.DropdownElement.SelectedOption.Text;

        public virtual void SelectOptionByText(string text, bool partialMatch = false) 
            => this.DropdownElement.SelectByText(text, partialMatch);
    }
}
