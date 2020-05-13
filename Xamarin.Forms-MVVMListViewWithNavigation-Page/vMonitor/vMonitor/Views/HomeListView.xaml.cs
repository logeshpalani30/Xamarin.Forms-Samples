using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vMonitor.Models;
using vMonitor.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace vMonitor.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeListView : ContentPage
	{
	    public HomeListView()
	    {
	        InitializeComponent();

	        BindingContext = new HomeViewModel();
	        
	    }

	    
	}
}