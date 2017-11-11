using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Afstandbediening.Droid
{
    [Activity(Label = "MainTo")]
    public class MainTo : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            Button favButton = FindViewById<Button>(Resource.Id.button1);
            Button searchButton = FindViewById<Button>(Resource.Id.button2);
            Button appButton = FindViewById<Button>(Resource.Id.button3);
            Button adminButton = FindViewById<Button>(Resource.Id.button4);
            Button logoutButton = FindViewById<Button>(Resource.Id.button5);

            favButton.Click += delegate
            {
                StartActivity(typeof(FavAct));
            };

            searchButton.Click += delegate
            {
                StartActivity(typeof(SearchAct));
            };

            appButton.Click += delegate
            {
                StartActivity(typeof(AppsAct));
            };

            adminButton.Click += delegate
            {
                StartActivity(typeof(AdminAct));
            };

            logoutButton.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };

        }
    }
}