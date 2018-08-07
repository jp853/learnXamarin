using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DeliveriesApp.Droid
{
	[Activity (Label = "DeliveriesApp.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
        EditText nameEditText;
        Button helloButton;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

            nameEditText = FindViewById<EditText>(Resource.Id.nameEditText);
            helloButton = FindViewById<Button>(Resource.Id.helloButton);

            helloButton.Click += HelloButton_Click;
		}

        private void HelloButton_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, $"Hello {nameEditText.Text}", ToastLength.Long).Show();
        }
    }
}


