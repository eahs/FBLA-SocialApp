using System;
using Xamarin.Forms;
using FBLASocialApp.Services;
using FBLASocialApp.iOS;
using InstabugLib;

[assembly: Dependency(typeof(BugReporterIOS))]
namespace FBLASocialApp.iOS
{
    public class BugReporterIOS : IBugReporter
    {
        public void Trigger()
        {
            Instabug.Show();
        }
    }
}
