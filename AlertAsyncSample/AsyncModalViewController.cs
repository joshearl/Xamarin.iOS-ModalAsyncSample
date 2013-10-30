using System;
using MonoTouch.UIKit;

namespace AlertAsyncSample
{
    public partial class AsyncModalViewController : UIViewController
    {
        public Action<object> Dismissed { get; set; }

        public AsyncModalViewController() : base ("AsyncModalViewController", null) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            dismissButton.TouchUpInside += (sender, e) => 
            {
                DismissViewController(true, null);
                Dismissed(messageTextField.Text);
            };
        }
    }
}