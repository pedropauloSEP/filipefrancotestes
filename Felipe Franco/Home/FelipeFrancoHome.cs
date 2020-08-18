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
    public class FelipeFrancoHome
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
            
                driver.Close();
                driver.Dispose();
          
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
        public void TheFelipeFrancoHomeTest()
        {
            driver.Navigate().GoToUrl("https://filipefranco.com.br/");
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[2]/div[2]/div/div/div/div/div[3]/div/div/a/span/span")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[13]/div/div/div/div/div/section[2]/div/div/div/div/div/div[5]/div/div/a/span/span")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[13]/div/div/div/div/div/section[2]/div/div/div[2]/div/div/div[5]/div/div/a/span/span")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[13]/div/div/div/div/div/section[2]/div/div/div[3]/div/div/div[5]/div/div/a")).Click();
            driver.FindElement(By.LinkText("Você prescreve dieta na sua consultoria fitness?")).Click();
            driver.FindElement(By.Id("elementor-tab-title-4762")).Click();
            driver.FindElement(By.LinkText("Você prescreve treinos para malhar em casa?")).Click();
            driver.FindElement(By.Id("elementor-tab-title-4764")).Click();
            driver.FindElement(By.Id("elementor-tab-title-4765")).Click();
            driver.FindElement(By.LinkText("De quanto em quanto tempo você troca a planilha de treino?")).Click();
            driver.FindElement(By.LinkText("E se a minha academia não tiver a máquina que você passou?")).Click();
            driver.FindElement(By.LinkText("Quando começa a vigência do plano de consultoria?")).Click();
            driver.FindElement(By.LinkText("Como vou saber se estou malhando certo?")).Click();
            driver.FindElement(By.Id("elementor-tab-title-47610")).Click();
            driver.FindElement(By.LinkText("O seu app funciona para Android e iOS")).Click();
            driver.FindElement(By.LinkText("Qual o preço da versão premium do app?")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div/div/div/div[5]/div/ul/li/a/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div/div/div/div[5]/div/ul/li[2]/a/span[2]")).Click();
     
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div[2]/div/div/div[3]/div/ul/li/a/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div[2]/div/div/div[3]/div/ul/li[2]/a/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div[2]/div/div/div[3]/div/ul/li[3]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div[2]/div/div/div[3]/div/ul/li[4]/a/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div[2]/div/div/div[3]/div/ul/li[6]/a/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div[2]/div/div/div[3]/div/ul/li[7]/a/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div[3]/div/div/div[3]/div/ul/li/a/span[2]")).Click();
    
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div[3]/div/div/div[3]/div/ul/li[2]/a/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div[3]/div/div/div[3]/div/ul/li[3]/a/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div[3]/div/div/div[3]/div/ul/li[4]/a/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div[3]/div/div/div[3]/div/ul/li[5]/a/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div[3]/div/div/div[3]/div/ul/li[6]/a/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div/div/div/section[20]/div/div/div[3]/div/div/div[3]/div/ul/li[7]/a/span[2]")).Click();
            
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
