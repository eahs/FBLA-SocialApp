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
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";

        public App()
        {
            Barrel.ApplicationId = "fblasocialapp";

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzMwOTQwQDMxMzgyZTMyMmUzMENJSEhmbkhkUm5SMFMwT1lRampEY3diZFo3QmtOVTdQQXFtOW5vMVlLeGs9");

            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
