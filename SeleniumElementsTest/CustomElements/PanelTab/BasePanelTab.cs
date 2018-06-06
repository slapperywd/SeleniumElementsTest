using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumElementsTest.CustomElements.PanelTab
{
    public abstract class BasePanelTab<TEnum> where TEnum : struct 
    {
        protected abstract Dictionary<TEnum, Type> PossibleTabsMap { get; set; }

        public abstract T ClickTab<T>(TEnum tabToSelect) where T : BaseTab;
    }
}
