
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FBLASocialApp.Views.Settings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class READMEPage : ContentPage
    {
        public READMEPage()
        {
            InitializeComponent();

            BindingContext = this;

        }

        public string ContentURL { get; set; } = "https://eahs.github.io/FBLASocialApp/index.html" + Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);


    }
}