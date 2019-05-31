using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignTask2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacebookPage : TabbedPage, INotifyPropertyChanged
    {
        public FacebookPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this.facebookPage, false);
            NavigationPage.SetHasNavigationBar(this, false); 

        }
    }
}