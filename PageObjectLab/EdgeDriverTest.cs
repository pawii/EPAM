using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectLab.Pages;


namespace PageObjectLab
{
    [TestClass]
    public class MinskToysTest
    {
        private const string SiteUrl = "https://brest.minsktoys.by";
        private IWebDriver browser;

        [TestInitialize]
        public void Initialize()
        {
            browser = new ChromeDriver();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            browser.Manage().Window.Maximize();
            browser.Navigate().GoToUrl(SiteUrl);
        }

        [TestMethod]
        public void PurchaseToy_EnterEmptyPhoneNumber_EmptyFieldErrorAppears()
        {
            const string emptyFieldErrorText = "Заполните это поле";
            var mainPage = new MainPage(browser);
            var toyInfoPage = new ToyInfoPage(browser);

            mainPage.SelectToyClick();
            toyInfoPage.PurchaseToyClick();
            toyInfoPage.SendOrderClick();

            Assert.AreEqual(emptyFieldErrorText, toyInfoPage.GetNameErrorText());
        }

        [TestMethod]
        public void Register_EnterThreeSymbolsInPasswordField_PasswordLengthErrorAppears()
        {
            const string passwordErrorText = "Минимум 6 символов";
            const string password = "123";
            var mainPage = new MainPage(browser);
            var registerPage = new RegisterPage(browser);

            mainPage.LoginClick();
            mainPage.RegisterClick();
            registerPage.EnterPassword(password);
            registerPage.RegisterClick();

            Assert.AreEqual(passwordErrorText, registerPage.GetPasswordError());
        }

        [TestCleanup]
        public void Cleanup()
        {
            browser.Quit();
        }
    }
}
