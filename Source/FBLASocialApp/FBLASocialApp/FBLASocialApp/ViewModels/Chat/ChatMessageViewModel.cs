using System;
using System.Collections.ObjectModel;
using FBLASocialApp.Models.Chat;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using SocialApi.Models;
using SocialApi;
using System.Collections.Generic;

namespace FBLASocialApp.ViewModels.Chat
{
    /// <summary>
    /// ViewModel for chat message page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class ChatMessageViewModel : BaseViewModel
    {
        #region Fields

        /// <summary>
        /// Stores the message text in an array. 
        /// </summary>
       

        private string profileName;

        private string newMessage;

        private string profileImage;

        private string connectionId;

        private int sessionId;

        private int memberId;

        private string body;

        private ObservableCollection<ChatMessage> chatMessageInfo = new ObservableCollection<ChatMessage>();

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageViewModel" /> class.
        /// </summary>
        public ChatMessageViewModel(int sessionId)
        {
            this.MakeVoiceCall = new Command(this.VoiceCallClicked);
            this.MakeVideoCall = new Command(this.VideoCallClicked);
            this.MenuCommand = new Command(this.MenuClicked);
            this.ShowCamera = new Command(this.CameraClicked);
            this.SendAttachment = new Command(this.AttachmentClicked);
            this.SendCommand = new Command(this.SendClicked);
            this.BackCommand = new Command(this.BackButtonClicked);
            this.ProfileCommand = new Command(this.ProfileClicked);
            this.GetActiveChatCommand = new Command(this.GetActiveChatClicked);
            this.ConnectToChatCommand = new Command(this.ConnectToChatClicked);
            this.AddChatSessionMemberCommand = new Command(this.AddChatSessionMemberClicked);
            this.RemoveChatSessionMemberCommand = new Command(this.RemoveChatSessionMemberClicked);
            this.AddChatMessageCommand = new Command(this.AddChatMessageClicked);
            
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the profile name.
        /// </summary>
        public string ProfileName
        {
            get
            {
                return this.profileName;
            }

            set
            {
                this.profileName = value;
                this.NotifyPropertyChanged();
            }
        }

        public string ConnectionId
        {
            get
            {
                return this.connectionId;
            }

            set
            {
                this.connectionId = value;
                this.NotifyPropertyChanged();
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

        public int MemberId
        {
            get
            {
                return this.memberId;
            }

            set
            {
                this.memberId = value;
                this.OnPropertyChanged("MemberId");
            }
        }

        public string Body
        {
            get
            {
                return this.body;
            }

            set
            {
                this.body = value;
                this.OnPropertyChanged("Body");
            }
        }

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
        /// Gets or sets a collection of chat messages.
        /// </summary>
        public ObservableCollection<SocialApi.Models.ChatMessage> ChatMessageInfo
        {
            get
            {
                return this.chatMessageInfo;
            }

            set
            {
                this.chatMessageInfo = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a new message.
        /// </summary>
        public string NewMessage
        {
            get
            {
                return this.newMessage;
            }

            set
            {
                this.newMessage = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region Commands

        /// <summary>
        /// Gets or sets the command that is executed when the profile name is clicked.
        /// </summary>
        public Command ProfileCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the voice call button is clicked.
        /// </summary>
        public Command MakeVoiceCall { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the video call button is clicked.
        /// </summary>
        public Command MakeVideoCall { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the menu button is clicked.
        /// </summary>
        public Command MenuCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the camera button is clicked.
        /// </summary>
        public Command ShowCamera { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the attachment button is clicked.
        /// </summary>
        public Command SendAttachment { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the send button is clicked.
        /// </summary>
        public Command SendCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the back button is clicked.
        /// </summary>
        public Command BackCommand { get; set; }
        public Command GetActiveChatCommand { get; set; }

        public Command ConnectToChatCommand { get; set; }

        public Command AddChatSessionMemberCommand { get; set; }

        public Command RemoveChatSessionMemberCommand { get; set; }

        public Command AddChatMessageCommand { get; set; }

        #endregion

        #region Methods

      
       

        /// <summary>
        /// Invoked when the voice call button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void VoiceCallClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the video call button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void VideoCallClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the menu button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void MenuClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the camera icon is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void CameraClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the attachment icon is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void AttachmentClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the send button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void SendClicked(object obj)
        {
            if (!string.IsNullOrWhiteSpace(this.NewMessage))
            {
                this.ChatMessageInfo.Add(new ChatMessage
                {
                    Body = this.NewMessage,
                    CreatedAt = DateTime.Now
                });
            }

            this.NewMessage = null;
        }

        /// <summary>
        /// Invoked when the back button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void BackButtonClicked(object obj)
        {
            await Shell.Current.GoToAsync("..");
        }

        /// <summary>
        /// Invoked when the Profile name is clicked.
        /// </summary>
        private void ProfileClicked(object obj)
        {
            // Do something
        }

        private async void GetActiveChatClicked(object obj)
        {
            if (IsBusy) return;

            IsBusy = true;


            await SocialApi.Chat.GetActiveChatSessions();
        }

        public async void ConnectToChatClicked(object obj)
        {
            if (IsBusy) return;

            IsBusy = true;

            await SocialApi.Chat.ConnectToChatSessions(connectionId);
        }


        public async void AddChatSessionMemberClicked(object obj)
        {
            if (IsBusy) return;

            IsBusy = true;

            await SocialApi.Chat.AddChatSessionMember(sessionId, memberId);
        }

        public async void RemoveChatSessionMemberClicked(object obj)
        {
            if (IsBusy) return;

            IsBusy = true;

            await SocialApi.Chat.RemoveChatSessionMember(sessionId, memberId);
        }

        public async void AddChatMessageClicked(object obj)
        {
            if (IsBusy) return;

            IsBusy = true;

            await SocialApi.Chat.AddChatMessage(sessionId, body);
        }

        #endregion
    }
}
