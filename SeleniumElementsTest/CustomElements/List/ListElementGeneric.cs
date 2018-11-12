namespace SeleniumElementsTest.CustomElements.List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OpenQA.Selenium;

    public class ListElementGeneric<T> where T : BaseListItem
    {
        private readonly By ListItemLct;

        public ListElementGeneric(By listItemLct)
        {
            this.ListItemLct = listItemLct;
        }

        public List<T> GetItems() => DriverExtensions.GetElements(this.ListItemLct)
            .Select(itemContainer => (T)Activator.CreateInstance(typeof(T), itemContainer))
            .ToList();
    }
}
