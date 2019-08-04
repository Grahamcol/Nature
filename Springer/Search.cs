using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;

namespace Springer
{
    class Search
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        { driver = new ChromeDriver("C:\\");
            driver.Url = "https://link.springer.com/";
        }
        [Test]
        public void searchtest()
        { IWebElement searchbox = driver.FindElement(By.Id("query"));
            searchbox.SendKeys("Multiphase flow");
            driver.FindElement(By.Id("search")).Click();
            IWebElement searchresults = driver.FindElement(By.Id("results-list"));
            Assert.IsTrue(searchresults.Text.Contains("Experimental and Computational Multiphase Flow"), "FAIL: Search results do not contain searched for value");
            driver.FindElement(By.Id("logo")).Click();
            driver.FindElement(By.Id("query")).SendKeys("Xenotaxidermy through the ages");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("search")).Click();
            String noresults = driver.FindElement(By.Id("no-results-message")).Text;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Assert.IsTrue(noresults.Contains("Sorry – we couldn’t find what you are looking for"), "FAIL: Search results message not as expected " + noresults);
            }
        [TearDown]
        public void closebrowser()
        { driver.Close(); }
    }
}
