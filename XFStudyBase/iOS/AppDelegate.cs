using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using XFStudyBase.Util;

namespace XFStudyBase.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // ライフサイクルメソッド調査
            Trace.WriteMethod();

            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        public override bool WillFinishLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            // ライフサイクルメソッド調査
            Trace.WriteMethod();

            return base.WillFinishLaunching(uiApplication, launchOptions);
        }

        public override void OnActivated(UIApplication uiApplication)
        {
            // ライフサイクルメソッド調査
            Trace.WriteMethod();

            base.OnActivated(uiApplication);
        }

        public override void OnResignActivation(UIApplication uiApplication)
        {
            // ライフサイクルメソッド調査
            Trace.WriteMethod();

            base.OnResignActivation(uiApplication);
        }

        public override void DidEnterBackground(UIApplication uiApplication)
        {
            // ライフサイクルメソッド調査
            Trace.WriteMethod();

            base.DidEnterBackground(uiApplication);
        }

        public override void WillEnterForeground(UIApplication uiApplication)
        {
            // ライフサイクルメソッド調査
            Trace.WriteMethod();

            base.WillEnterForeground(uiApplication);
        }

        public override void WillTerminate(UIApplication uiApplication)
        {
            // ライフサイクルメソッド調査
            Trace.WriteMethod();

            base.WillTerminate(uiApplication);
        }
    }
}
