using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace GitHubAutomation.Pages
{
    public class RegisterPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='input_PASSWORD']")]
        private IWebElement PasswordTextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='input_NAME']")]
        private IWebElement EmailTextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='registraion-page-form']/div[6]/button")]
        private IWebElement RegisterButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='input_PASSWORD-error']")]
        private IWebElement PasswordErrorLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='input_EMAIL - error']")]
        private IWebElement EmailErrorLabel { get; set; }
        

        public RegisterPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public void EnterPassword(string password) => PasswordTextBox.SendKeys(password);

        public void EnterEmail(string email) => EmailTextBox.SendKeys(email);

        public void RegisterClick() => RegisterButton.Click();

        public string GetPasswordError() => PasswordErrorLabel.Text;

        public string GetEmailError() => EmailErrorLabel.Text;
    }
}