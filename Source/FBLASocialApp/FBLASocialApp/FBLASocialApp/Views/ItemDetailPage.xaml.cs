using System.ComponentModel;
using Xamarin.Forms;
using FBLASocialApp.ViewModels;

namespace FBLASocialApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}