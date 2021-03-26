using FBLASocialApp.ViewModels.AllMembers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FBLASocialApp.Views.AllMembers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllMembersPage : ContentPage
    {
        private AllMembersViewModel AllMembersViewModel;
        public AllMembersPage()
        {
            InitializeComponent();

            BindingContext = AllMembersViewModel = new AllMembersViewModel();

            AllMembersViewModel.LoadItemsCommand.Execute(null);
        }
    }
}