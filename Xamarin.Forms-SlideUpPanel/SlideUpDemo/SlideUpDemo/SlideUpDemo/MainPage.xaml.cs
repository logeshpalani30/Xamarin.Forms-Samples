using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DK.SlidingPanel.Interface;
using ReactiveUI;
using SlideUpDemo.ViewModels;
using Xamarin.Forms;

namespace SlideUpDemo
{
	public partial class MainPage : ContentPage
	{
	    private TestPageAllXamlViewModel ViewModel;
	    //private Label label;

	    protected override void OnBindingContextChanged()
	    {
	        base.OnBindingContextChanged();

	        this.ViewModel = BindingContext as TestPageAllXamlViewModel;

	        this.spTest.SetBinding(SlidingUpPanel.PanelRatioProperty, new Binding { Path = "PanelRatio" });
	        this.spTest.SetBinding(SlidingUpPanel.HideTitleViewProperty, new Binding { Path = "HideTitleView" });
            
	        this.spTest.WhenPanelRatioChanged += SpTest_WhenPanelRatioChanged;
	        this.spTest.WhenSlidingPanelStateChanged += SpTest_WhenSlidingPanelStateChanged;

            SlidingPanelConfig config = new SlidingPanelConfig();

	        config.PrimaryFloatingActionButton = GetPrimaryFloatingActionButton();
	        config.SecondaryFloatingActionButton = GetSecondaryFlotingButton();

            spTest.ApplyConfig(config);

            


            if (spTest.CurrentState != SlidingPanelState.Expanded)
	        {
	            spTest.HidePanel();
                
	        }
	        else
	        {
                spTest.ShowCollapsedPanel();
	        }


        }

        private Image GetSecondaryFlotingButton()
        {
            Image primaryImage = new Image();
            primaryImage.HeightRequest = 48;
            primaryImage.WidthRequest = 48;
            primaryImage.Margin = new Thickness(0, 6, 0, 0);
            primaryImage.Source = ImageSource.FromFile("StopButton.png");

            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            primaryImage.GestureRecognizers.Add(tapGestureRecognizer);
            return (primaryImage);
        }

        private Image GetPrimaryFloatingActionButton()
	    {
            Image primaryImage = new Image();
	        primaryImage.HeightRequest = 48;
	        primaryImage.WidthRequest = 48;
            primaryImage.Source = ImageSource.FromFile("PlayButton.png");

            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            primaryImage.GestureRecognizers.Add(tapGestureRecognizer);
	        return (primaryImage);
	    }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            this.ViewModel.IsPlaying = !(this.ViewModel.IsPlaying);
        }

        public MainPage()
		{
			InitializeComponent();
		}
	    private void SpTest_WhenSlidingPanelStateChanged(object sender, DK.SlidingPanel.Interface.StateChangedEventArgs e)
	    {
	        switch (e.State)
	        {
	            case SlidingPanelState.Expanded:
	                
	               // NavigationPage.SetHasNavigationBar(this, false);
	                break;
	            case SlidingPanelState.Collapsed:
	            case SlidingPanelState.Hidden:
	            default:
	                //NavigationPage.SetHasNavigationBar(this, true);
	                break;
	        }
	    }
        private void SpTest_WhenPanelRatioChanged(object sender, EventArgs e)
	    {
	        spTest.ShowCollapsedPanel();
	    }
        private void BackButtonTapGesture_Tapped(object sender, EventArgs e)
	    {
	        spTest.ShowCollapsedPanel();
	    }

	    private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
	        this.ViewModel.IsPlaying = !(this.ViewModel.IsPlaying);
        }
	}
}
