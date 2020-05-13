using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Xamarin.Forms;
using Lamp.Plugin;

namespace LampDemo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private void Switch_OnToggled(object sender, ToggledEventArgs e)
        {

            if (e.Value == true)
            {
                CrossLamp.Current.TurnOn();
                label.Text = "Flash Light is Turn On : "+e.Value.ToString();
            }

            else
            {
                CrossLamp.Current.TurnOff();
                label.Text = "Flash Light is turn Off : "+e.Value.ToString();
            }
                
        }
    }
}
