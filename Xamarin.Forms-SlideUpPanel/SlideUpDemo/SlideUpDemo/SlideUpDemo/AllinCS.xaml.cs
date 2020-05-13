using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DK.SlidingPanel.Interface;
using SlideUpDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SlideUpDemo
{
	
	public partial class AllinCS : ContentPage
	{
		public AllinCS ()
		{
			InitializeComponent ();
		}

	    private TestViewModel ViewModel;

        protected override void OnBindingContextChanged()
	    {
	        base.OnBindingContextChanged();

	        this.ViewModel = BindingContext as TestViewModel;

	        SetupSlidingPanel();

	       
	    }

	    private void SetupSlidingPanel()
	    {
	        SlidingPanelConfig config = new SlidingPanelConfig();
	        config.MainView = GetMainStackLayout();
	        config.HideNavBar = true;

            spTest.ApplyConfig(config);
        }
	    private StackLayout GetMainStackLayout()
	    {
	        StackLayout mainStackLayout = new StackLayout();
	        mainStackLayout.VerticalOptions = LayoutOptions.FillAndExpand;
	        mainStackLayout.HorizontalOptions = LayoutOptions.FillAndExpand;
	        Label label = new Label
	        {
                Text = "Logesh Palani"
	        };
	        mainStackLayout.Children.Add(label);

	        return (mainStackLayout);
	    }
    }
}