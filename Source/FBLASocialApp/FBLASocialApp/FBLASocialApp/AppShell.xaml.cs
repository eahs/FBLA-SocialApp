using System;
using System.Collections.Generic;
using FBLASocialApp.ViewModels;
using FBLASocialApp.Views;
using FBLASocialApp.Views.Chat;
using FBLASocialApp.Views.Wall;
using Xamarin.Forms;

namespace FBLASocialApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute("Chat/Session", typeof(ChatMessagePage));
            
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
