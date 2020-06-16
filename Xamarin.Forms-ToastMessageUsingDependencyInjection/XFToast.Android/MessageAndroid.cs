// 22:15
using System;
using Android.App;
using Android.Widget;
using XFToast.Droid;
using XFToast.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(MessageAndroid))]
namespace XFToast.Droid
{
    public class MessageAndroid : IMessage
    {
        public MessageAndroid()
        {
        }
        public void ShortAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
        public void LongAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }
    }
}
