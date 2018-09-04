namespace SeleniumElementsTest.CustomElements.CustomDropdown
{
    using OpenQA.Selenium;

    public class MoreDropdown : BaseCustomDropdown
    {
        protected override By DropDownContainerLocator { get; set; } = By.CssSelector("#uhf-g-nav li.nested-menu");

        protected override By DropdownOptionLocator { get; set; } = By.CssSelector("ul li a");

        protected override By ExpandDropdownButtonLocator { get; set; } = By.CssSelector("button#c-shellmenu_4");
    }
}
