using System;
using System.Collections.ObjectModel;
using FBLASocialApp.Models.Chat;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using SocialApi.Models;

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
        private readonly string[] descriptions = { "Hi, Jill! My name is FBLA Judge. I am an alumni of Carnegie Mellon University. I just saw your recent post about your Swan Lake performance.",
            "Can you tell me more about your dance?",
            "Hello, Mr. Alex! It's very nice to meet you. I can definitely tell you more about my dance.",
            "I started learning ballet when I was five years old at the local dance studio. At age eleven, I auditioned for the Lincoln Performing Arts School and was accepted." +
            "\n" + "Now, I have been a student there throughout my middle school and high school career. With my school's ballet team, I have competed in several state and national competitions." +
            "\n" + "Apart from competitions, I take great pride in being a part of our school's productions of famous ballets. I truly enjoy working with the younger students during rehearsals and encouraging their love for dance. Here is a picture from our production of the Nutcracker",
            "Wow, I congratulate you on your accomplishments! I would like to get to know you more. Would you be open for an interview on this Saturday at 1:00 PM?",
            "Yes, I would. Thank you so much for the offer! I look forward to speaking with you.",
            "I look forward to speaking with you as well. The interview will be over phonecall. Here is my number: 567-897-9050",
            "Thank you! Have a wonderful day!",
        };

        private string profileName = "Jill Booker";

        private string newMessage;

        private string profileImage = App.BaseImageUrl + "ProfileImage3.png";

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

            this.GenerateMessageInfo();
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

        #endregion

        #region Methods

        /// <summary>
        /// Initializes a collection and add it to the message items.
        /// </summary>
        private void GenerateMessageInfo()
        {
            var currentTime = DateTime.Now;
            this.ChatMessageInfo = new ObservableCollection<ChatMessage>
            {
                new ChatMessage
                {
                    Body = this.descriptions[0],
                    CreatedAt = currentTime.AddMinutes(-60),
                },
                new ChatMessage
                {
                    Body = this.descriptions[1],
                    CreatedAt = currentTime.AddMinutes(-59),
                },
                new ChatMessage
                {
                    Body = this.descriptions[2],
                    CreatedAt = currentTime.AddMinutes(-45),
                    IsReceived = true,
                },
                new ChatMessage
                {
                    Body = this.descriptions[3],
                    CreatedAt = currentTime.AddMinutes(-40),
                    IsReceived = true,
                },
                new ChatMessage
                {
                    Image = App.BaseImageUrl + "Electronics.png",
                    CreatedAt = currentTime.AddMinutes(-38),
                    IsReceived = true,
                },
                new ChatMessage
                {
                    Body = this.descriptions[4],
                    CreatedAt = currentTime.AddMinutes(-26),
                },
                new ChatMessage
                {
                    Body = this.descriptions[5],
                    CreatedAt = currentTime.AddMinutes(-23),
                    IsReceived = true,
                },
                new ChatMessage
                {
                    Body = this.descriptions[6],
                    CreatedAt = currentTime.AddMinutes(-21),
                },
                new ChatMessage
                {
                    Body = this.descriptions[7],
                    CreatedAt = currentTime.AddMinutes(-17),
                    IsReceived = true,
                },

            };
        }

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

        #endregion
    }
}
