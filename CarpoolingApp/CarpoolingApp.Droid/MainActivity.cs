﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//using Android.Gms.Maps;

namespace CarpoolingApp.Droid
{
    [Activity(Label = "Egypt", Icon = "@drawable/carpooling", 
        Theme = "@style/MainTheme", 
        MainLauncher = false, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
    

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            global::Xamarin.FormsMaps.Init(this, bundle);
            LoadApplication(new App());
           // var geoUri = Android.Net.Uri.Parse("geo:42.374260,-71.120824");
            //var mapIntent = new Intent(Intent.ActionView, geoUri);
           // StartActivity(mapIntent);
        }
    }
}

