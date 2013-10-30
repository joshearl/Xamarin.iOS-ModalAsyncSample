// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace AlertAsyncSample
{
	[Register ("AlertAsyncSampleViewController")]
	partial class AlertAsyncSampleViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel ResultLabel { get; set; }

		[Action ("ShowAlertButtonTapped:")]
		partial void ShowAlertButtonTapped (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ResultLabel != null) {
				ResultLabel.Dispose ();
				ResultLabel = null;
			}
		}
	}
}
