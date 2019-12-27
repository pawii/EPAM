using AngleSharp.Text;
using NUnit.Framework;
using GitHubAutomation.Pages;
using GitHubAutomation.Services;


namespace GitHubAutomation.Tests
{
    [TestFixture]
    public class WebTests : GeneralConfig
    {
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
        public void Register_EnterDifferentPasswords_ErrorAppears()
        {
            const string EXPECTED_ERROR = "Пароли не совпадают";
            var mainPage = new MainPage(Driver);
            var registerPage = new RegisterPage(Driver);

            mainPage.LoginClick();
            mainPage.RegisterClick();
            registerPage.EnterPassword(TestDataReader.GetTestData("Password"));
            registerPage.EnterConfirmPassword(TestDataReader.GetTestData("ConfirmPassword"));
            registerPage.RegisterClick();

            Assert.AreEqual(EXPECTED_ERROR, registerPage.GetConfirmPasswordError());
        }

        [Test]
        public void OrderToy_EnterEmptyPhoneNumber_EmptyFieldErrorAppears()
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
        public void OrderToy_EnterInvalidPhone_InvalidEmailErrorAppears()
        {
            const string emailErrorText = "Неверный формат";
            var mainPage = new MainPage(Driver);
            var registerPage = new RegisterPage(Driver);

            mainPage.LoginClick();
            mainPage.RegisterClick();
            registerPage.EnterPhoneNumber(TestDataReader.GetTestData("PhoneNumber"));
            registerPage.RegisterClick();

            Assert.AreEqual(emailErrorText, registerPage.GetPhoneError());
        }

        [Test]
        public void ViewToy_SelectToyForGirls_ContainsToyForGirlsOrForBoysAndGirlsInfo()
        {
            string[] EXPECTES_SPECIFICATIONS = { "Для мальчиков и девочек", "Для девочек" };
            var mainPage = new MainPage(Driver);
            var childrenToysPage = new ChildrenToysPage(Driver);
            var girlsToysPage = new GirlsToysPage(Driver);
            var viewToyPage = new ViewToyPage(Driver);

            mainPage.ChildrenToysClick();
            childrenToysPage.GirlsToysClick();
            girlsToysPage.ClickOnFirstToy();

            Assert.IsTrue(EXPECTES_SPECIFICATIONS.Contains(viewToyPage.GetToysSexInfo(false)));
        }

        [Test]
        public void ViewToy_SelectToyForBoys_ContainsToyForBoysOrForBoysAndGirlsInfo()
        {
            string[] EXPECTES_SPECIFICATIONS = { "Для мальчиков и девочек", "Для мальчиков" };
            var viewToyPage = new ViewToyPage(Driver);

            SelectFirstBoyToy();

            Assert.IsTrue(EXPECTES_SPECIFICATIONS.Contains(viewToyPage.GetToysSexInfo(true)));
        }

        [Test]
        public void ViewToy_SelectToyForBoy_AgeInfoNotEmpty()
        {
            var viewToyPage = new ViewToyPage(Driver);

            SelectFirstBoyToy();

            Assert.IsFalse(string.IsNullOrEmpty(viewToyPage.GetAgeInfo()));
        }

        [Test]
        public void ViewToy_SelectToyForBoy_BoxMaterialInfoNotEmpty()
        {
            var viewToyPage = new ViewToyPage(Driver);

            SelectFirstBoyToy();

            Assert.IsFalse(string.IsNullOrEmpty(viewToyPage.GetBoxMaterialInfo()));
        }

        [Test]
        public void ViewToy_SelectToyForBoy_BoxSizeInfoNotEmpty()
        {
            var viewToyPage = new ViewToyPage(Driver);

            SelectFirstBoyToy();

            Assert.IsFalse(string.IsNullOrEmpty(viewToyPage.GetBoxSizeInfo()));
        }
    }
}
