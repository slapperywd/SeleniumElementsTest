namespace SeleniumElementsTest.CustomElements
{
    using System.Collections.Generic;
    using System.Linq;

    using OpenQA.Selenium;

    public class ListElement
    {
        private readonly By ListItemLocator;

        public ListElement(By listItemLocator)
        {
            this.ListItemLocator = listItemLocator;
        }

        public List<IWebElement> GetItems() => 
            DriverExtensions.WaitForElement(this.ListItemLocator).FindElements(this.ListItemLocator).ToList();
    }
}
