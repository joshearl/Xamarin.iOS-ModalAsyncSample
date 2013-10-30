using System;
using System.Threading.Tasks;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace AlertAsyncSample
{
    public partial class AlertAsyncSampleViewController : UIViewController
    {
        public AlertAsyncSampleViewController() : base("AlertAsyncSampleViewController", null) { }

        async partial void ShowAlertButtonTapped(NSObject sender) {

            var message = await ShowModal();
            ResultLabel.Text = message.ToString();

            // this also works
            // Task.Factory.StartNew(async () => {
            //     var message = await ShowModal();
            //     ResultLabel.Text = message;
            // });
        }

        public Task<object> ShowModal() 
        {
            var tcs = new TaskCompletionSource<object>();

            UIApplication.SharedApplication.InvokeOnMainThread(new NSAction(() =>
            {
                var modal = new AsyncModalViewController();
                modal.Dismissed = tcs.SetResult;
                PresentViewController(modal, true, null);
            }));
           
            return tcs.Task;
        }
    }
}