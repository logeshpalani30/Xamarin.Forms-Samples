// 21:01
using System;
using System.Security.Cryptography;
using System.Text;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFPayUMoney.CustomView;
using XFPayUMoney.Droid;

[assembly: ExportRenderer(typeof(PayWebView), typeof(PayWebViewRendererAndroid))]
namespace XFPayUMoney.Droid
{
    public class PayWebViewRendererAndroid : WebViewRenderer
    {
        public PayWebViewRendererAndroid(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var myWebView = Element as PayWebView;
                var postData = Encoding.UTF8.GetBytes(myWebView.PostData);
                Control.PostUrl(myWebView.url, postData);
            }
        }
    }
}
