using RestarantAppDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestarantAppDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourasalPage1 : ContentPage
    {
        public CourasalPage1()
        {
            InitializeComponent();
            BindingContext = new MainImageViewModel();
        }

        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
           MainImageViewModel viewModel  = this.BindingContext as MainImageViewModel;
           await Navigation.PushAsync(new ListViewCollectionCheck(viewModel?.list));
        }
    }                                    
}                                        