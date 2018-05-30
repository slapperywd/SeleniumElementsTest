using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumElementsTest
{
    public class Driver
    {
        private static IWebDriver _driver;
        public static IWebDriver Instance => _driver ?? (_driver = new ChromeDriver());
    }
}
