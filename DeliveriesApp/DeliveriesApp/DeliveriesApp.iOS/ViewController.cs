using System;

using UIKit;

namespace DeliveriesApp.iOS
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

            helloButton.TouchUpInside += HelloButton_TouchUpInside;
		}

        private void HelloButton_TouchUpInside(object sender, EventArgs e)
        {
            var alert = UIAlertController.Create("Hello", $"Hello {nameTextField.Text}", UIAlertControllerStyle.Alert);

            var cancelAction = UIAlertAction.Create("Hello", UIAlertActionStyle.Cancel, null);

            alert.AddAction(cancelAction);

            PresentViewController(alert, true, null);
        }

        public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

