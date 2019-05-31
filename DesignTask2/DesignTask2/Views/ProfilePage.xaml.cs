using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignTask2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                label1.TextColor = Color.LightGray;
                box1.Color = Color.LightGray;
                label3.TextColor = Color.LightGray;
                box3.Color = Color.LightGray;
                label4.TextColor = Color.LightGray;
                box4.Color = Color.LightGray;
                label2.TextColor = Color.DodgerBlue;
                box2.Color = Color.DodgerBlue;
                tweetLayout.IsVisible = false;
                likeLayout.IsVisible = false;
                mediaLayout.IsVisible = false;
                replyLayout.IsVisible = true;

            };
            label2.GestureRecognizers.Add(tapGestureRecognizer);
            var tapGestureRecognizer2 = new TapGestureRecognizer();
            tapGestureRecognizer2.Tapped += (s, e) =>
            {
                label1.TextColor = Color.LightGray;
                box1.Color = Color.LightGray;
                label2.TextColor = Color.LightGray;
                box2.Color = Color.LightGray;
                label4.TextColor = Color.LightGray;
                box4.Color = Color.LightGray;
                label3.TextColor = Color.DodgerBlue;
                box3.Color = Color.DodgerBlue;
                tweetLayout.IsVisible = false;
                likeLayout.IsVisible = false;
                replyLayout.IsVisible = false;
                mediaLayout.IsVisible = true;

            };
            label3.GestureRecognizers.Add(tapGestureRecognizer2);
            var tapGestureRecognizer3 = new TapGestureRecognizer();
            tapGestureRecognizer3.Tapped += (s, e) =>
            {
                label1.TextColor = Color.LightGray;
                box1.Color = Color.LightGray;
                label2.TextColor = Color.LightGray;
                box2.Color = Color.LightGray;
                label3.TextColor = Color.LightGray;
                box3.Color = Color.LightGray;
                label4.TextColor = Color.DodgerBlue;
                box4.Color = Color.DodgerBlue;
                tweetLayout.IsVisible = false;
                mediaLayout.IsVisible = false;
                replyLayout.IsVisible = false;
                likeLayout.IsVisible = true;
            };
            label4.GestureRecognizers.Add(tapGestureRecognizer3);
            var tapGestureRecognizer4 = new TapGestureRecognizer();
            tapGestureRecognizer4.Tapped += (s, e) =>
            {
                label4.TextColor = Color.LightGray;
                box4.Color = Color.LightGray;
                label2.TextColor = Color.LightGray;
                box2.Color = Color.LightGray;
                label3.TextColor = Color.LightGray;
                box3.Color = Color.LightGray;
                label1.TextColor = Color.DodgerBlue;
                box1.Color = Color.DodgerBlue;
                replyLayout.IsVisible = false;
                mediaLayout.IsVisible = false;
                likeLayout.IsVisible = false;
                tweetLayout.IsVisible = true;
            };
            label1.GestureRecognizers.Add(tapGestureRecognizer4);

        }
        

        private async void ArrowImageButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UsersListPage());
        }

        private async void MenuImageButton_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Hey", "The Options Not Set", "OK");
        }

        private async void SettingImageButton_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Hey", "The Options Not Set", "OK");
        }

        private async void FollowButton_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Hey", "Now, You follwing Me", "OK");
        }
    }
}