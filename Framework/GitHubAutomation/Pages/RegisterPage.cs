using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace GitHubAutomation.Pages
{
    public class RegisterPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='input_PASSWORD']")]
        private IWebElement PasswordTextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='input_EMAIL']")]
        private IWebElement EmailTextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='input_PERSONAL_PHONE']")]
        private IWebElement PhoneTextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='input_CONFIRM_PASSWORD']")]
        private IWebElement ConfirmPasswordTextBox { get; set; }
        


        [FindsBy(How = How.XPath, Using = "//*[@id='registraion-page-form']/div[6]/button")]
        private IWebElement RegisterButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='input_PASSWORD-error']")]
        private IWebElement PasswordErrorLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='input_EMAIL-error']")]
        private IWebElement EmailErrorLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='input_PERSONAL_PHONE-error']")]
        private IWebElement PhoneErrorLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='input_CONFIRM_PASSWORD-error']")]
        private IWebElement ConfirmPasswordErrorLabel { get; set; }

        public RegisterPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public void EnterPassword(string password) => PasswordTextBox.SendKeys(password);
        public void EnterEmail(string email) => EmailTextBox.SendKeys(email);
        public void EnterPhoneNumber(string phone) => PhoneTextBox.SendKeys(phone);
        public void EnterConfirmPassword(string phone) => ConfirmPasswordTextBox.SendKeys(phone);


        public void RegisterClick() => RegisterButton.Click();


        public string GetPasswordError() => PasswordErrorLabel.Text;
        public string GetEmailError() => EmailErrorLabel.Text;
        public string GetPhoneError() => PhoneErrorLabel.Text;
        public string GetConfirmPasswordError() => ConfirmPasswordErrorLabel.Text;
    }
}