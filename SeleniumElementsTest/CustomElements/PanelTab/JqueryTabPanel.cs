using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumElementsTest.CustomElements.PanelTab
{
    public class JqueryTabPanel : BasePanelTab<JuqeryPanelTabs>
    {
        protected override Dictionary<JuqeryPanelTabs, Type> PossibleTabsMap { get; set; }

        public override T ClickTab<T>(JuqeryPanelTabs tabToSelect)
        {
            //Find appropriate map
            var tabMap = PossibleTabsMap.FirstOrDefault(s => s.Key.Equals(tabToSelect)).Value;
            T tab = (T)Activator.CreateInstance(tabMap);
            tab.Click();

            return tab;
        }

        public JqueryTabPanel()
        {
            this.PossibleTabsMap = new Dictionary<JuqeryPanelTabs, Type>
            {
                [JuqeryPanelTabs.Paris] = typeof(ParisTabComponent)
            };
        }
    }
}
