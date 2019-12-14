using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace lab5
{
    [TestClass]
    public class UnitTest1
    {
        private ChromeDriver browser;

        [TestMethod]
        public void TestMethod1()
        {
            OpenWebSite();

            var logginInButton = browser.FindElement(By.XPath("/html/body/div[5]/div[1]/header/div[1]/div/div/div[2]/div/div/a/span/span"));
            logginInButton.Click();

            var loginInputBox = browser.FindElement(By.XPath
                ("/html/body/div[15]/div/div[2]/div/div/div[1]/div/div/form/div[1]/div/div/div/input"));
            loginInputBox.SendKeys("pawii@yandexru");

            var passwordInputBox = browser.FindElement(By.XPath
                ("/html/body/div[15]/div/div[2]/div/div/div[1]/div/div/form/div[2]/div/div/div/input"));
            passwordInputBox.SendKeys("123");

            var enterButton = browser.FindElement(By.XPath("/html/body/div[15]/div/div[2]/div/div/div[1]/div/div/form/div[3]/div[2]/input"));
            enterButton.Click();
        }

        private void FindXPathAndClick(string xPath)
        {

        }

        private void OpenWebSite()
        {
            browser = new ChromeDriver();
            browser.Manage().Window.Maximize();
            browser.Navigate().GoToUrl("https://brest.minsktoys.by");
        }
    }
}
