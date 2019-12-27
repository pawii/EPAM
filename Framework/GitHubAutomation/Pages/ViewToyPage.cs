using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace GitHubAutomation.Pages
{
    public class ViewToyPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='bx_117848907_6597']/div[2]/div/div[2]/div[2]/div[1]/div/div[2]/div[2]/div[2]")]
        private IWebElement BoyToySexInfo { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='bx_117848907_11877']/div[2]/div/div[2]/div[2]/div[1]/div/div[2]/div[2]/div[2]/div")]
        private IWebElement GirlToySexInfo { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='bx_117848907_6597']/div[2]/div/div[2]/div[2]/div[1]/div/div[2]/div[1]/div[2]/div")]
        private IWebElement AgeInfo { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='bx_117848907_6597']/div[2]/div/div[2]/div[2]/div[1]/div/div[2]/div[3]/div[2]/div")]
        private IWebElement BoxSizeInfo { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='bx_117848907_6597']/div[2]/div/div[2]/div[2]/div[1]/div/div[2]/div[4]/div[2]/div")]
        private IWebElement BoxMaterialInfo { get; set; }

        public ViewToyPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public string GetToysSexInfo(bool isBoy) => isBoy ? BoyToySexInfo.Text : GirlToySexInfo.Text;
        public string GetAgeInfo() => AgeInfo.Text;
        public string GetBoxSizeInfo() => BoxSizeInfo.Text;
        public string GetBoxMaterialInfo() => BoxMaterialInfo.Text;
    }
}
