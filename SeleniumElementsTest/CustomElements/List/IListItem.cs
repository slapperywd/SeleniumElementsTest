namespace SeleniumElementsTest.CustomElements.List
{
    using OpenQA.Selenium;

    public abstract class BaseListItem
    {
        protected IWebElement ItemContainer { get; }

        public BaseListItem(IWebElement itemContainer)
        {
            this.ItemContainer = itemContainer;
        }
    }
}