using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokedex.Droid
{
    [Activity(Label = "Pokedex", Icon = "@mipmap/icon", Theme = "@style/TemaApp", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Herencia
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            
        }
    }
}