// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using System.Text;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;



namespace Selenium.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            //testing a url
            //creating the object of firefox 
            IWebDriver driver = new FirefoxDriver();

            //assigning a url 
            driver.Url = "https://www.facebook.com/";

            //element -email and password text field button click

         
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("Selenium_tests");
            driver.FindElement(By.XPath("//input[@id='pass']")).SendKeys("Selenium_password"); 

            //driver.FindElement(By.XPath("//ul[@id='loginbutton']")).Click();
            driver.Quit();
        }
        [Test]
        public void testBrowser()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.lambdatest.com/blog/complete-guide-for-using-xpath-in-selenium-with-examples/");
            driver.Manage().Window.Maximize();
            driver.Manage().Window.Minimize();
            driver.Close();
            driver.Quit();

        }
        
       
    }
}
