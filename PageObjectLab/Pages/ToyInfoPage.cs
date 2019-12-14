using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace PageObjectLab.Pages
{
    public class ToyInfoPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='bx_117848907_10263']/div[2]/div/div[2]/div[2]/div[2]/div[2]/div/div[3]/span")]
        private IWebElement PurchaseToyButton { get; set; }
        [FindsBy(How = How.Id, Using = "one_click_buy_form_button")]
        private IWebElement SendOrderButton { get; set; }
        [FindsBy(How = How.Id, Using = "one_click_buy_id_FIO-error")]
        private IWebElement NameErrorLabel { get; set; }

        private readonly IWebDriver browser;

        public ToyInfoPage(IWebDriver browser)
        {
            this.browser = browser;
            PageFactory.InitElements(browser, this);
        }

        public void PurchaseToyClick() => PurchaseToyButton.Click();

        public void SendOrderClick() => SendOrderButton.Click();

        public string GetNameErrorText() => NameErrorLabel.Text;
    }
}
