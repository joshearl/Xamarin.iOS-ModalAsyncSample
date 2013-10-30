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
	[Register ("AsyncModalViewController")]
	partial class AsyncModalViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton dismissButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField messageTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (dismissButton != null) {
				dismissButton.Dispose ();
				dismissButton = null;
			}

			if (messageTextField != null) {
				messageTextField.Dispose ();
				messageTextField = null;
			}
		}
	}
}
