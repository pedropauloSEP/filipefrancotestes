using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestClass]
    public class FelipeFrancoPlanos
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;
        private bool acceptNextAlert = true;

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
        }

        [ClassCleanup]
        public static void CleanupClass()
        {
            try
            {
                //driver.Quit();// quit does not close the window
                driver.Close();
                driver.Dispose();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        [TestInitialize]
        public void InitializeTest()
        {
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void TheFelipeFrancoPlanosTest()
        {
            driver.Navigate().GoToUrl("https://filipefranco.com.br/produto/30-dias-de-consultoria-fitness-online/");
            driver.FindElement(By.Name("add-to-cart")).Click();
            driver.FindElement(By.XPath("//img[@alt='Filipe Franco Personal Trainer']")).Click();
            driver.FindElement(By.XPath("//img[@alt='90 dias de consultoria fitness online FILIPE FRANCO PERSONAL TRAINER']")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_1 | ]]
            driver.Close();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_2 | ]]
            driver.Close();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_3 | ]]
            driver.Close();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
