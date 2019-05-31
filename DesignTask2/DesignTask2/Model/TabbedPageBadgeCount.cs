using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DesignTask2.Model
{
    public class TabbedPageBadgeCount : TabbedPage
    {
        public bool Labels { get; set; }
        public TabDataCount badgeCount { get; set; }

        public Dictionary<int, TabDataCount> Tabs = new Dictionary<int, TabDataCount>();
        public TabbedPageBadgeCount()
        {
            Tabs.Add(0, new TabDataCount() {BadgeCaption = 5, BadgeColor = Color.Red});
        }
    }
}
