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
    public class FelipeFrancoPlanilhasProntas
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
        public void TheFelipeFrancoPlanilhasProntasTest()
        {
            driver.Navigate().GoToUrl("https://filipefranco.com.br/planilhas-de-musculacao-prontas/");
            driver.FindElement(By.XPath("//header[@id='masthead']/div/div/div/div/div[4]/a/div")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_1 | ]]
            driver.Close();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            driver.FindElement(By.XPath("//article[@id='post-4896']/div/div/div/div/section[2]/div[2]/div/div/div/div/div[3]/div/div/a/span/span")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_2 | ]]
            driver.Close();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            driver.FindElement(By.XPath("//article[@id='post-4896']/div/div/div/div/section[6]/div/div/div/div/div[2]/div[3]/div/div/a/span/span")).Click();
            driver.FindElement(By.XPath("//article[@id='post-4896']/div/div/div/div/section[6]/div/div/div[2]/div/div[2]/div[3]/div/div/a/span/span")).Click();
            driver.FindElement(By.XPath("//article[@id='post-4896']/div/div/div/div/section[6]/div/div/div[3]/div/div[2]/div[3]/div/div/a/span/span")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_3 | ]]
            driver.Close();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_4 | ]]
            driver.Close();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            driver.FindElement(By.LinkText("PLANOS DE CONSULTORIA")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_5 | ]]
            driver.Close();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            driver.FindElement(By.XPath("//article[@id='post-4896']/div/div/div/div/section[12]/div[2]/div/div/div/div/div/div/h2")).Click();
            driver.FindElement(By.XPath("//article[@id='post-4896']/div/div/div/div/section[12]/div[2]/div/div/div/div/div/div/h2")).Click();
            driver.FindElement(By.XPath("//article[@id='post-4896']/div/div/div/div/section[15]/div[2]/div/div/div/div/section[2]/div/div/div/div/div/div[3]/div/div/a/span/span")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_6 | ]]
            driver.Close();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            driver.FindElement(By.XPath("//article[@id='post-4896']/div/div/div/div/section[18]/div/div/div/div/div/div[5]/div/ul/li/a/span[2]")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_7 | ]]
            driver.Close();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            // ERROR: Caught exception [ERROR: Unsupported command [selectFrame | index=2 | ]]
            driver.FindElement(By.Id("ic_close")).Click();
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
