using System;
using Xamarin.Forms;
using FBLASocialApp.Services;
using Com.Instabug.Bug;
using Com.Instabug.Library;

[assembly: Dependency(typeof(FBLASocialApp.Droid.BugReporterDroid))]
namespace FBLASocialApp.Droid
{
    public class BugReporterDroid : IBugReporter
    {
        public void Trigger()
        {
            Instabug.Show();
        }
    }
}
