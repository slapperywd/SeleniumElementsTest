using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumElementsTest.CustomElements.PanelTab
{
    public abstract class BaseTab
    {
        protected abstract By TabLocator { get; set; }

        public abstract bool IsActive();

        public virtual bool IsDisplayed() => DriverExtensions.WaitForElement(TabLocator).Displayed;

        public virtual void Click() => DriverExtensions.WaitForElement(TabLocator).Click();
    }
}
