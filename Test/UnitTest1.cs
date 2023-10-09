using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Test

{
    public class Tests
    {
        IWebDriver driver;
        string baseURL;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.multitran.com/";
            driver.Url = baseURL;
        }

        [TestCase]
        public void signup()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.XPath("/html/body/div/div[3]/div/a[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div/div[5]/form/table/tbody/tr[1]/td[2]/input")).SendKeys("Name");
            driver.FindElement(By.XPath("/html/body/div/div[5]/form/table/tbody/tr[2]/td[2]/input")).SendKeys("Password");
            driver.FindElement(By.XPath("/html/body/div/div[5]/form/table/tbody/tr[4]/td/input")).Click();
        }
        [TestCase]
        public void UrlTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.XPath("/html/body/div/div[5]/table/tbody/tr[3]/td[1]/a[1]")).Click();
        }
        [TestCase]
        public void NotFound()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
           
            driver.FindElement(By.XPath("/html/body/div/div[5]/form/span/input")).SendKeys("Hello");
            driver.FindElement(By.XPath("/html/body/div[1]/div[5]/form/input")).Click();
        }
        [TestCase]
        public void FindTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.XPath("/html/body/div/div[5]/table/tbody/tr[3]/td[1]/a[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div/div[5]/form/span/input")).SendKeys("Hello");
            driver.FindElement(By.XPath("/html/body/div[1]/div[5]/form/input[3]")).Click() ;
        }
    }
}