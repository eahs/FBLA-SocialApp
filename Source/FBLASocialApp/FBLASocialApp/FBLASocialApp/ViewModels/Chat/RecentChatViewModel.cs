using System.Collections.ObjectModel;
using FBLASocialApp.Models.Chat;
using SocialApi;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using System.Collections.Generic;
using System.ComponentModel;
using FBLASocialApp.ViewModels.AllMembers;
using System.Threading.Tasks;
using SocialApi.Response.v1;
using SocialApi.Models;
using System;

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
        private ObservableCollection<ChatSession> sessionsList;
        private Member selfParticipant;
        private int sessionId;
        private string profileImage = /*App.BaseImageUrl + */ "https://yakka.tech/images/FBLAProfilePic.jpg";

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
                    ImagePath = /* App.BaseImageUrl + */  "https://yakka.tech/images/JillBooker.jpg",
                    SenderName = "Jill Booker",
                    MessageType = "Text",
                    Message = "Thank you! Have a wonderful day!",
                    Time = "17 min",
                    NotificationType = "Viewed"
                },
                new ChatDetail
                {
                    ImagePath = /*App.BaseImageUrl + */  "https://yakka.tech/images/RobertSmith.jpg",
                    SenderName = "Robert Smith",
                    MessageType = "Text",
                    Message = "Thank you for the pleasant conversation. I hope to be in contact again soon.",
                    Time = "11/20/20",
                    NotificationType = "Sent"
                },
                new ChatDetail
                {
                    ImagePath = /*App.BaseImageUrl + */  "https://yakka.tech/images/NinaMiller.jpg",
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
            this.MenuCommand = new Command(this.MenuButton_Clicked);
            this.ProfileImageCommand = new Command(this.ProfileImageClicked);
            this.GetChatSessionCommand = new Command(this.GetChatSessionClicked);
            
        }
        #endregion

        protected override async Task LoadItemsAsync()
        {
            // Basic pattern
            try
            {



                // Make async request to obtain data
                ApiResponse<List<ChatSession>> response = await SocialApi.Chat.GetActiveChatSessions();

                if (response.ErrorCount == 0)
                {
                    IsError = false;
                    DataAvailable = true;

                    //this.memberList = new ObservableCollection<Member>(response.Result);
                    foreach (var chatSession in response.Result)
                    {
                        SessionsList.Add(chatSession);
                    }

                }

                else
                {
                    // An error occurred that is stored
                    ErrorMessage = "An error occurred";
                    DataAvailable = false;
                    IsError = true;
                }

                ApiResponse<Member> self = await Members.GetMember();

                if (self.ErrorCount == 0)
                {
                    IsError = false;
                    DataAvailable = true;

                    this.SelfParticipant = self.Result;
                }
                else
                {
                    // An error occurred that is stored
                    ErrorMessage = "An error occurred";
                    DataAvailable = false;
                    IsError = true;
                }
            }
            catch (Exception e)
            {
                // An exception occurred
                DataAvailable = false;
            }


        }

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

        public Member SelfParticipant
        {
            get
            {
                return this.selfParticipant;
            }

            set
            {
                this.selfParticipant = value;
                this.OnPropertyChanged("SelfParticipant");
            }
        }

        public int SessionId
        {
            get
            {
                return this.sessionId;
            }

            set
            {
                this.sessionId = value;
                this.OnPropertyChanged("SessionId");
            }
        }

        public ObservableCollection<ChatSession> SessionsList
        {
            get
            {
                return this.sessionsList;
            }

            set
            {
                this.sessionsList = value;
                this.OnPropertyChanged("SessionsList");
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

        public Command GetChatSessionCommand { get; set; }
        public Command OpenPopupCommand { get; set; }

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
        private async void MenuButton_Clicked(object obj)
        {
            await Shell.Current.GoToAsync("//AllMembers");
        }

        public async void GetChatSessionClicked(object obj)
        {
            if (IsBusy) return;

            IsBusy = true;

            await SocialApi.Chat.GetChatSession(sessionId);
        }

       /* public string OtherMemberName()
        {
            var memberList;
            foreach (var chatSession in sessionsList)
            {
                memberList.Add(chatSession.ChatMembers);

                if (memberList.Member.Equals(selfParticipant))
                {
                   memberList.Remove();
                }

                else
                    return ChatSession.ChatMembers[1].FullName;
            }

            
        }*/

        #endregion

    }
}
