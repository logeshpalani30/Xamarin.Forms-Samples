using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DesignTask2.Interfaces
{
    public interface IToolbarBadge
    {
        void SetBadge(Page page,ToolbarItem item, string value,Color   backgroundColor,Color textColor);
    }
}
