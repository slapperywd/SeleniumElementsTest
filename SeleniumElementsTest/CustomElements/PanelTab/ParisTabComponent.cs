using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumElementsTest.CustomElements.PanelTab
{
    public class ParisTabComponent : BaseTab
    {
        protected override By TabLocator { get; set; } = By.XPath("//li/a[text()='Paris']");

        public override bool IsActive()
        {
            throw new NotImplementedException();
        }
    }
}
