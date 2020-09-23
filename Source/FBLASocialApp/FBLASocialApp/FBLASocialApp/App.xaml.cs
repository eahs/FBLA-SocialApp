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

        public App()
        {
            Barrel.ApplicationId = "fblasocialapp";

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
