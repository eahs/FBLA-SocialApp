using System.Collections.ObjectModel;
using FBLASocialApp.Models.Chat;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace FBLASocialApp.ViewModels.Chat
{
    /// <summary>
    /// View model for recent chat page 
    /// </summary> 
    [Preserve(AllMembers = true)]
    public class RecentChatViewModel : BaseViewModel
    {
        #region Fields

        private ObservableCollection<ChatDetail> chatItems;

        private string profileImage = App.BaseImageUrl + "ProfileImage1.png";

        private Command itemSelectedCommand;

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="RecentChatViewModel" /> class.
        /// </summary>
        public RecentChatViewModel()
        {
            this.ChatItems = new ObservableCollection<ChatDetail>
            {
                new ChatDetail
                {
                    ImagePath = App.BaseImageUrl + "ProfileImage2.png",
                    SenderName = "Jill Booker",
                    MessageType = "Text",
                    Message = "Thank you! Have a wonderful day!",
                    Time = "17 min",
                    NotificationType = "Viewed"
                },
                new ChatDetail
                {
                    ImagePath = App.BaseImageUrl + "ProfileImage3.png",
                    SenderName = "Robert Smith",
                    MessageType = "Text",
                    Message = "Thank you for the pleasant conversation. I hope to be in contact again soon.",
                    Time = "11/20/20",
                    NotificationType = "Sent"
                },
                new ChatDetail
                {
                    ImagePath = App.BaseImageUrl + "ProfileImage4.png",
                    SenderName = "Nina Miller",
                    MessageType = "Text",
                    Message = "Would 10:15 PM work?",
                    Time = "Yesterday",
                    NotificationType = "New"
                },
                
            };

            this.MakeVoiceCallCommand = new Command(this.VoiceCallClicked);
            this.MakeVideoCallCommand = new Command(this.VideoCallClicked);
            this.ShowSettingsCommand = new Command(this.SettingsClicked);
            this.MenuCommand = new Command(this.MenuClicked);
            this.ProfileImageCommand = new Command(this.ProfileImageClicked);
        }
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the profile image.
        /// </summary>
        public string ProfileImage
        {
            get
            {
                return this.profileImage;
            }

            set
            {
                this.profileImage = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that has been bound with a list view, which displays the profile items.
        /// </summary>
        public ObservableCollection<ChatDetail> ChatItems
        {
            get
            {
                return this.chatItems;
            }

            set
            {
                if (this.chatItems == value)
                {
                    return;
                }

                this.chatItems = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region Commands
        /// <summary>
        /// Gets or sets the command that is executed when the voice call button is clicked.
        /// </summary>
        public Command MakeVoiceCallCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the video call button is clicked.
        /// </summary>
        public Command MakeVideoCallCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the settings button is clicked.
        /// </summary>
        public Command ShowSettingsCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the menu button is clicked.
        /// </summary>
        public Command MenuCommand { get; set; }

        /// <summary>
        /// Gets the command that is executed when an item is selected.
        /// </summary>
        public Command ItemSelectedCommand
        {
            get { return this.itemSelectedCommand ?? (this.itemSelectedCommand = new Command(this.ItemSelected)); }
        }

        /// <summary>
        /// Gets or sets the command that is executed when the profile image is clicked.
        /// </summary>
        public Command ProfileImageCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when an item is selected.
        /// </summary>
        private async void ItemSelected(object selectedItem)
        {
            // Do something
            
            await Shell.Current.GoToAsync("//Yakka/Chat/Session?sessionId=30");
        }

        /// <summary>
        /// Invoked when the Profile image is clicked.
        /// </summary>
        private void ProfileImageClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the voice call button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void VoiceCallClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the video call button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void VideoCallClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the settings button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void SettingsClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the menu button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void MenuClicked(object obj)
        {
            // Do something
        }

        #endregion
    }
}
