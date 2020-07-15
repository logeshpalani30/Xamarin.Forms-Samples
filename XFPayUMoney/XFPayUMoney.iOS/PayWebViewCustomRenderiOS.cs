using System;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFPayUMoney.CustomView;
using XFPayUMoney.iOS;

[assembly: ExportRenderer(typeof(PayWebView), typeof(PayWebViewCustomRenderiOS))]
namespace XFPayUMoney.iOS
{
    public class PayWebViewCustomRenderiOS : WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (NativeView != null)
            {
                var mywebview = Element as PayWebView;

                var request = new NSMutableUrlRequest(new NSUrl(new NSString(mywebview.url)));
                request.Body = mywebview.PostData;
                request.HttpMethod = "POST";

                NSMutableDictionary dic = new NSMutableDictionary();
                dic.Add(new NSString("Content-Type"), new NSString("application/json"));
                request.Headers = dic;

                LoadRequest(request);
            }
        }
    }
}
