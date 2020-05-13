using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using Plugin.CurrentActivity;
using SnackBarDemo.Droid;
[assembly:Xamarin.Forms.Dependency(typeof(SnackBar_Android))]

namespace SnackBarDemo.Droid
{
    public class SnackBar_Android : SnackInterface
    {
        public void SnackbarShow(string message)
        {
            Activity activity = CrossCurrentActivity.Current.Activity;
            Android.Views.View view = activity.FindViewById(Android.Resource.Id.Content);
            Snackbar.Make(view,message,Snackbar.LengthLong).Show();
        }
    }
}