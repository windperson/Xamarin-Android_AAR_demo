﻿using Android.App;
using Android.Widget;
using Android.OS;
using Com.Xamarin.Textcounter;

namespace BindingTest
{
    [Activity(Label = "BindingTest", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            TestAARbinding();
        }

        private void TestAARbinding()
        {
            var numVowels = TextCounter.NumVowels("");
            return;
        }
    }
}

