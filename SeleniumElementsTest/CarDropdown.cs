using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumElementsTest
{
    public class CarDropdown : BaseDropdown
    {
        protected override By DropdownLocator { get; set; } = By.XPath("(//select)[1]");
    }
}
