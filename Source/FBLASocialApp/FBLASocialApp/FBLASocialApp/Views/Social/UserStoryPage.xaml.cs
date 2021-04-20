using FBLASocialApp.ViewModels.Social;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FBLASocialApp.Views.Social
{
    /// <summary>
    /// Page to show the social profile with connections page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserStoryPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStoryPage" /> class.
        /// </summary>
        /// 
        private UserStoryViewModel UserStoryViewModel;
        public UserStoryPage()
        {
           
        InitializeComponent();
            BindingContext = UserStoryViewModel = new UserStoryViewModel();

            UserStoryViewModel.LoadItemsCommand.Execute(null);
        }
    }
}