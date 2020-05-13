using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestarantAppDemo.ViewModels;
using RestarantAppDemo.Views;
using Xamarin.Forms;

namespace RestarantAppDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel _vm;
        public MainPage()
        {
            InitializeComponent();
            BindingContext= new MainImageViewModel();
        }
        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
            MainImageViewModel viewModel = this.BindingContext as MainImageViewModel;
            await Navigation.PushAsync(new ListViewCollectionCheck(viewModel?.list));
        }
    }
}
