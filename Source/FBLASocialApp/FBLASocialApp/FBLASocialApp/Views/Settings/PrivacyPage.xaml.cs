
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FBLASocialApp.Views.Settings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrivacyPage : ContentPage
    {
        public PrivacyPage()
        {
            InitializeComponent();

            BindingContext = this;

        }

        public string ContentURL { get; set; } = "https://eahs.github.io/FBLASocialApp/PRIVACY.html?" + Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);


    }
}