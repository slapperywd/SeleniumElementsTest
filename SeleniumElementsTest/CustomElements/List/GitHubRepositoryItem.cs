namespace SeleniumElementsTest.CustomElements.List
{
    using OpenQA.Selenium;

    public class GitHubRepositoryItem : BaseListItem
    {
        private static readonly By RepoNameLct = By.XPath(".//h3/a[@itemprop='name codeRepository']");
        private static readonly By RepoDescriptionLct = By.XPath(".//p[@itemprop='description']");
        private static readonly By ProgrammingLanguageLct = By.XPath(".//span[@itemprop='programmingLanguage']");
        private static readonly By DateTimeLct = By.XPath(".//relative-time");

        public GitHubRepositoryItem(IWebElement itemContainer) : base(itemContainer)
        {
        }

        private IWebElement RepositoryLink => DriverExtensions.WaitForElement(this.ItemContainer, RepoNameLct);

        public string RepositoryName => this.RepositoryLink.Text;

        public string Description => DriverExtensions.GetElementSafe(this.ItemContainer, RepoDescriptionLct)?.Text;

        public string ProgrammingLanguage => DriverExtensions.GetElementSafe(this.ItemContainer, ProgrammingLanguageLct)?.Text;

        public string Date => DriverExtensions.WaitForElement(this.ItemContainer, DateTimeLct).Text;

        public void ClickRepositoryLink() => this.RepositoryLink.Click();
    }
}
