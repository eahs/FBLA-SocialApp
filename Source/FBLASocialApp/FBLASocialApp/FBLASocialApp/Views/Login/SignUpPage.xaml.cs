using FBLASocialApp.ViewModels.Login;
using System;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FBLASocialApp.Views.Login
{
    /// <summary>
    /// Page to sign in with user details.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignUpPage" /> class.
        /// </summary>
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            birthdayPicker.IsOpen = true;
        }

        private void birthdayPicker_DateSelected(object sender, Syncfusion.XForms.Pickers.DateChangedEventArgs e)
        {
            SignUpPageViewModel vm = this.BindingContext as SignUpPageViewModel;

            BirthdayEntry.Text = ((DateTime)e.NewValue).ToShortDateString();

        }
    }
}