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


                }
    }
}
