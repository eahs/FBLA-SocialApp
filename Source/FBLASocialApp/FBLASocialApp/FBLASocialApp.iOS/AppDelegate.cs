using Syncfusion.XForms.iOS.RichTextEditor;
using Syncfusion.XForms.iOS.TabView;
using Syncfusion.XForms.iOS.Graphics;
using Syncfusion.XForms.iOS.BadgeView;
using Syncfusion.XForms.iOS.Cards;
using Syncfusion.SfRating.XForms.iOS;
using Syncfusion.XForms.iOS.Core;
using Syncfusion.ListView.XForms.iOS;
using  Syncfusion.XForms.iOS.Graphics;
using Syncfusion.XForms.iOS.Border;
using Syncfusion.XForms.iOS.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Syncfusion.XForms.Pickers.iOS;
using InstabugLib;

namespace FBLASocialApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
global::Xamarin.Forms.Forms.Init();
SfRichTextEditorRenderer.Init();
SfTabViewRenderer.Init();
            SfBadgeViewRenderer.Init();
            SfCardViewRenderer.Init();
            SfRatingRenderer.Init();
            Core.Init();
            SfListViewRenderer.Init();
            SfGradientViewRenderer.Init();
            SfBorderRenderer.Init();
            SfButtonRenderer.Init();

            LoadApplication(new App());

            SfDatePickerRenderer.Init();

            Instabug.StartWithToken("de0e8acfa86980fd8b252abd14d086fc", IBGInvocationEvent.Shake);
            IBGBugReporting.InvocationEvents = IBGInvocationEvent.FloatingButton;

            return base.FinishedLaunching(app, options);
        }
    }
}
