using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace GitHubAutomation.Pages
{
    public class GirlsToysPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='bx_3966226736_11877']/div/div[2]/div[1]/a")]
        private IWebElement FirstToyButton { get; set; }

        public GirlsToysPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public void ClickOnFirstToy() => FirstToyButton.Click();
    }
}