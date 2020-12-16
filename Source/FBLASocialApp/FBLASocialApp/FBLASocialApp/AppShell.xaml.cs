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
            
            Routing.RegisterRoute("Yakka/Chat/Session", typeof(ChatMessagePage));
            
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void Logout_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Login");
        }

        private async void Favorites_Clicked(object sender, EventArgs e)
        {
            FlyoutIsPresented = false;
            await Shell.Current.GoToAsync("//Yakka/Favorites");
        }

        private async void Chat_Clicked(object sender, EventArgs e)
        {
            FlyoutIsPresented = false;
            await Shell.Current.GoToAsync("//Yakka/Chat");
        }

        private async void MyWall_Clicked(object sender, EventArgs e)
        {
            FlyoutIsPresented = false;
            await Shell.Current.GoToAsync("//Yakka/MyWall");
        }

        private async void NewPost_Clicked(object sender, EventArgs e)
        {
            FlyoutIsPresented = false;
            await Shell.Current.GoToAsync("//Yakka/NewPost");
        }

    }
}
