using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace GitHubAutomation.Pages
{
    public class ChildrenToysPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='bx_1847241719_291']")]
        private IWebElement BoysToysButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='bx_1847241719_290']")]
        private IWebElement GirlsToysButton { get; set; }


        public ChildrenToysPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public void BoysToysClick() => BoysToysButton.Click();
        public void GirlsToysClick() => GirlsToysButton.Click();
    }
}
