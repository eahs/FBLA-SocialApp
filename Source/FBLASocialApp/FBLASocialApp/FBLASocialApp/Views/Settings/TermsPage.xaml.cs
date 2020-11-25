using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FBLASocialApp.Views.Settings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TermsPage : ContentPage
    {
        public TermsPage()
        {
            InitializeComponent();

            BindingContext = this;

        }

        public string ContentURL { get; set; } = "https://eahs.github.io/FBLASocialApp/TERMS.html?" + Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);

    }
}