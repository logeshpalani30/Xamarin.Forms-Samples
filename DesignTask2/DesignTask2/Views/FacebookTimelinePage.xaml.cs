using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignTask2.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignTask2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacebookTimelinePage : ContentPage
    {
        public FacebookTimelinePage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            
            //NavigationPage.BarBackgroundColor = Color.RoyalBlue;
            //((NavigationPage)Application.Current.MainPage).BarTextColor = Color.OrangeRed;
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }


        private void AddNotificationButton_OnClicked(object sender, EventArgs e)
        {
            if (ToolbarItems.Count > 0)
            {
                int CountValue = 2;

                DependencyService.Get<IToolbarBadge>().SetBadge(this, ToolbarItems.First(), CountValue.ToString(),
                    Color.Red, Color.White);
                
                CountValue++;

            }
        }
    }
}