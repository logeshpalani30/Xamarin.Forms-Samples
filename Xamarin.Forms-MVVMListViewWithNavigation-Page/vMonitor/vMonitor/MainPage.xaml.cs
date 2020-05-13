using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vMonitor.ViewModels;
using vMonitor.Views;
using Xamarin.Forms;

namespace vMonitor
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		    BindingContext = new HomeViewModel();
		}

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new HomeListView());
	    }

	    private async  void Button_OnClicked1(object sender, EventArgs e)
	    {
	        await DisplayActionSheet("Sign Up Application", "Cancel", "Permission Granded", "In this Application Designed by Logesh");
	    }
	}
}
