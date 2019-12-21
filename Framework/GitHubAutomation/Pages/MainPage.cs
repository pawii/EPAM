using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace GitHubAutomation.Pages
{
    public class MainPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='bx_3966226736_10263_HIT']/div/div[2]/div[1]/a")]
        private IWebElement SelectToyButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[1]/div/div/div[2]/div/div/a")]
        private IWebElement LoginButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='ajax_auth']/div/div[3]/div[1]/a")]
        private IWebElement RegisterButton { get; set; }


        public MainPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public void SelectToyClick() => SelectToyButton.Click();
        public void LoginClick() => LoginButton.Click();
        public void RegisterClick() => RegisterButton.Click();
    }
}
