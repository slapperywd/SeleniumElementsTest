
namespace SeleniumElementsTest.CustomElements.Buttons
{
    using OpenQA.Selenium;

    public class Button
    {
        private readonly By ButtonLocator;

        public Button(By by)
        {
            this.ButtonLocator = by;
        }

        public void Click()
        {
            DriverExtensions.WaitForElement(this.ButtonLocator).Click();
        }
    }
}
