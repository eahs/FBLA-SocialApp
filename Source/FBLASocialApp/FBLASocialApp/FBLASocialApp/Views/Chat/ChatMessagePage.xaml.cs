using FBLASocialApp.Models.Chat;
using Syncfusion.DataSource;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using SocialApi.Models;
using FBLASocialApp.ViewModels.Chat;
using Xamarin.Forms;
using System;

namespace FBLASocialApp.Views.Chat
{
    /// <summary>
    /// Page to show chat message list
    /// </summary>
    [QueryProperty("SessionId", "sessionId")]
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatMessagePage
    {
        private int sessionId = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessagePage" /> class.
        /// </summary>
        public ChatMessagePage()
        {
            InitializeComponent();

            ListView.DataSource.GroupDescriptors.Add(new GroupDescriptor
            {
                PropertyName = "Time",
                KeySelector = obj =>
                {
                    var item = obj as ChatMessage;
                    return item.CreatedAt.Date;
                }
            });
        }


        public string SessionId
        {
            set
            {
                string sid = Uri.UnescapeDataString(value);
                sessionId = Convert.ToInt32(sid);

                ChatMessageViewModel vm = new ChatMessageViewModel(sessionId);
                vm.LoadItemsCommand.Execute(null);

                this.BindingContext = vm;
            }
        }
    }
}