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
        { driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome\\Application");
        }
    }
}
