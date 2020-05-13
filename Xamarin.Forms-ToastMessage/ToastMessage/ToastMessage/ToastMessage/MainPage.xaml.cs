using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToastMessage
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    protected override void OnAppearing()
	    {
            ToastButton.Clicked += ToastButton_Clicked;
	    }

        private void ToastButton_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<Toast>().Show("Toast Message");
        }
    }
}
