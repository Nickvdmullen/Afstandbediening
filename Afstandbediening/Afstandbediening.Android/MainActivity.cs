using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Afstandbediening.Droid
{
	[Activity (Label = "Afstandbediening.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Login);

            // Get our button from the layout resource,
            // and attach an event to it

            Button loginbutton = FindViewById<Button>(Resource.Id.button1);

            loginbutton.Click += delegate
            {
                StartActivity(typeof(MainTo));
            };

		}
	}
}


