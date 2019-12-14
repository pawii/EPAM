using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace PageObjectLab.Pages
{
    public class RegisterPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='input_PASSWORD']")]
        private IWebElement PasswordTextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='registraion-page-form']/div[6]/button")]
        private IWebElement RegisterButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='input_PASSWORD-error']")]
        private IWebElement PasswordErrorLabel { get; set; }

        public RegisterPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public void EnterPassword(string password) => PasswordTextBox.SendKeys(password);
        public void RegisterClick() => RegisterButton.Click();
        public string GetPasswordError() => PasswordErrorLabel.Text;
    }
}