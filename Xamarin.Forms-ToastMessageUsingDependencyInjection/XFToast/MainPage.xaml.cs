using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFToast.Interface;

namespace XFToast
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {

            DependencyService.Get<IMessage>().ShortAlert("I'm Short Alert");
        }

        void Button_Clicked_1(Object sender, EventArgs e)
        {
            DependencyService.Get<IMessage>().LongAlert("I'm Long Alert");
        }
    }
}
