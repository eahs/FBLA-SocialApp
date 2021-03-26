using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FBLASocialApp.Services;
using FBLASocialApp.Views;
using MonkeyCache.FileStore;

namespace FBLASocialApp
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://yakka.tech/images/";
            // https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/;

        public App()
        {
            Barrel.ApplicationId = "fblasocialapp";

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzU3MTk3QDMxMzgyZTMzMmUzMGVhZWs4VWU3bVoySkRHREIrZXFFMzBPT0xNNWo4YndZMWhzRmxodmFCRjA9");

            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();

            if (!SocialApi.YakkaApi.Current.IsLoggedIn)
            {
                Shell.Current.GoToAsync("//Login");
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
