using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;

using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace Selenium.Tests
{
    [TestFixture]
    class TestClass1
    {
        //FindElements using Selectors and write in textbox and search
        [Test]
        public void WikiSearch()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("searchInput")).SendKeys("Selenium");
            driver.FindElement(By.XPath("//*[@id='search-form']/fieldset/button")).Click();
            driver.Close();
            driver.Quit();

        }

        //Select Dropdown by Text, Value and Index.
        public void WikiSearchCollection()
        {

        }

    }


}
