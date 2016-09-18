﻿using System;
using System.Reflection;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using EWiki.XF.Droid.BackgroundServices;
using EWiki.XF.Droid.Utils.IconizeModules;
using FormsPlugin.Iconize.Droid;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Plugin.Iconize.Fonts;
using Xamarin.Forms;

namespace EWiki.XF.Droid
{
    [Activity(Label = "EWiki.XF", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.tabs;
            ToolbarResource = Resource.Layout.toolbar;

            base.OnCreate(bundle);

            FFImageLoading.Forms.Droid.CachedImageRenderer.Init();
            FormsPlugin.Iconize.Droid.IconControls.Init();
            Plugin.Iconize.Iconize.With(new MaterialModule());
            Plugin.Iconize.Iconize.With(new LinearModule());
            IconControls.Init(Resource.Id.toolbar, Resource.Id.sliding_tabs);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            var cv = typeof(Xamarin.Forms.CarouselView);
            var assembly = Assembly.Load(cv.FullName);

            LoadApplication(new App(new AndroidInitializer()));

            StartLocationFeeder();
            SetupBackgroundServices();
        }

        private void StartLocationFeeder()
        {
            
        }

        private void SetupBackgroundServices()
        {
            MessagingCenter.Subscribe<StartTestBackgroundServiceMessage>(this, "StartTestBackgroundService", message => {
                var intent = new Intent(this, typeof(LocationFeederBackgroundService));
                StartService(intent);
            });

            MessagingCenter.Subscribe<StopTestBackgroundServiceMessage>(this, "StopTestBackgroundService", message => {
                var intent = new Intent(this, typeof(LocationFeederBackgroundService));
                StopService(intent);
            });
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {

        }
    }
}

