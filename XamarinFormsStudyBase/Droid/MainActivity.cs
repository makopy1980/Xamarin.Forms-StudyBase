using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamarinFormsStudyBase.Droid
{
    [Activity(Label = "XamarinFormsStudyBase.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            // ライフサイクルメソッド調査
            Util.Trace.WriteMethod();

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }

        protected override void OnStart()
        {
            // ライフサイクルメソッド調査
            Util.Trace.WriteMethod();

            base.OnStart();
        }

        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            // ライフサイクルメソッド調査
            Util.Trace.WriteMethod();

            base.OnPostCreate(savedInstanceState);
        }

        protected override void OnResume()
        {
            // ライフサイクルメソッド調査
            Util.Trace.WriteMethod();

            base.OnResume();
        }

        protected override void OnPostResume()
        {
            // ライフサイクルメソッド調査
            Util.Trace.WriteMethod();

            base.OnPostResume();
        }

        protected override void OnUserLeaveHint()
        {
            // ライフサイクルメソッド調査
            Util.Trace.WriteMethod();

            base.OnUserLeaveHint();
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            // ライフサイクルメソッド調査
            Util.Trace.WriteMethod();

            base.OnSaveInstanceState(outState);
        }

        protected override void OnPause()
        {
            // ライフサイクルメソッド調査
            Util.Trace.WriteMethod();

            base.OnPause();
        }

        public override bool OnCreateThumbnail(Android.Graphics.Bitmap outBitmap, Android.Graphics.Canvas canvas)
        {
            // ライフサイクルメソッド調査
            Util.Trace.WriteMethod();

            return base.OnCreateThumbnail(outBitmap, canvas);
        }

        protected override void OnStop()
        {
            // ライフサイクルメソッド調査
            Util.Trace.WriteMethod();

            base.OnStop();
        }

        protected override void OnDestroy()
        {
            // ライフサイクルメソッド調査
            Util.Trace.WriteMethod();

            base.OnDestroy();
        }

        protected override void OnRestart()
        {
            // ライフサイクルメソッド調査
            Util.Trace.WriteMethod();

            base.OnRestart();
        }


    }
}
