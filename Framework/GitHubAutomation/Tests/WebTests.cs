using NUnit.Framework;
using GitHubAutomation.Pages;
using GitHubAutomation.Services;


namespace GitHubAutomation.Tests
{
    [TestFixture]
    public class WebTests : GeneralConfig
    {
        [Test]
        public void PurchaseToy_EnterEmptyPhoneNumber_EmptyFieldErrorAppears()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string emptyFieldErrorText = "Заполните это поле";
                var mainPage = new MainPage(Driver);
                var toyInfoPage = new ToyInfoPage(Driver);

                mainPage.SelectToyClick();
                toyInfoPage.PurchaseToyClick();
                toyInfoPage.SendOrderClick();

                Assert.AreEqual(emptyFieldErrorText, toyInfoPage.GetNameErrorText());
            });
        }

        [Test]
        public void Register_EnterThreeSymbolsInPasswordField_PasswordLengthErrorAppears()
        {
            const string passwordErrorText = "Минимум 6 символов";
            var mainPage = new MainPage(Driver);
            var registerPage = new RegisterPage(Driver);

            mainPage.LoginClick();
            mainPage.RegisterClick();
            registerPage.EnterPassword(TestDataReader.GetTestData("Password"));
            registerPage.RegisterClick();

            Assert.AreEqual(passwordErrorText, registerPage.GetPasswordError());
        }

        [Test]
        public void Register_EnterInvalidEmail_InvalidEmailErrorAppears()
        {
            const string emailErrorText = "Неверный формат";
            var mainPage = new MainPage(Driver);
            var registerPage = new RegisterPage(Driver);

            mainPage.LoginClick();
            mainPage.RegisterClick();
            registerPage.EnterEmail(TestDataReader.GetTestData("Email"));
            registerPage.RegisterClick();

            Assert.AreEqual(emailErrorText, registerPage.GetEmailError());
        }

        [Test]
        public void OrderCall_EnterInvalidPhone_InvalidEmailErrorAppears()
        {
            const string emailErrorText = "Неверный формат";
            var mainPage = new MainPage(Driver);
            var registerPage = new RegisterPage(Driver);

            mainPage.LoginClick();
            mainPage.RegisterClick();
            registerPage.EnterEmail(TestDataReader.GetTestData("Email"));
            registerPage.RegisterClick();

            Assert.AreEqual(emailErrorText, registerPage.GetEmailError());
        }
    }
}
