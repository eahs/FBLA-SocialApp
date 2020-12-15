using Syncfusion.XForms.Buttons;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using ProfileModel = FBLASocialApp.Models.Profile;
using Model = SocialApi.Models.Post;
using SocialApi.Models;
using System;

namespace FBLASocialApp.ViewModels.Social
{
    /// <summary>
    /// ViewModel for social profile pages.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class UserStoryViewModel : BaseViewModel
    {
        #region Fields

        private ObservableCollection<ProfileModel> interests;

        private ObservableCollection<ProfileModel> connnections;

        private ObservableCollection<ProfileModel> pictures;

        private string headerImagePath;

        private string profileImage;

        private string backgroundImage;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="UserStoryViewModel" /> class.
        /// </summary>
        public UserStoryViewModel()
        {
            this.HeaderImagePath = "Album2.png";
            this.ProfileImage = "ProfileImage16.png";
            this.BackgroundImage = "Sky-Image.png";
            this.ProfileName = "Lela Cortez";
            this.Designation = "Designer";
            this.State = "San Francisco";
            this.Country = "CA";
            this.About = "I’m a UMN graduate (go Gophers!) and Minnesota native, but I’m already loving my new home in the Golden Gate City! I can’t wait to explore more of the great music scene here.";
            this.PostsCount = 8;
            this.FollowersCount = 45;
            this.FollowingCount = 45;

            this.Interests = new ObservableCollection<ProfileModel>()
            {
                new ProfileModel { Name = "Food", ImagePath = "Recipe12.png" },
                new ProfileModel { Name = "Travel", ImagePath = "Album5.png" },
                new ProfileModel { Name = "Music", ImagePath = "ArticleImage7.jpg" },
                new ProfileModel { Name = "Bags", ImagePath = "Accessories.png" },
                new ProfileModel { Name = "Market", ImagePath = "PersonalCare.png" },
                new ProfileModel { Name = "Food", ImagePath = "Recipe12.png" },
                new ProfileModel { Name = "Travel", ImagePath = "Album5.png" },
                new ProfileModel { Name = "Music", ImagePath = "ArticleImage7.jpg" },
                new ProfileModel { Name = "Bags", ImagePath = "Accessories.png" },
                new ProfileModel { Name = "Market", ImagePath = "PersonalCare.png" }
            };

            this.Connections = new ObservableCollection<ProfileModel>()
            {
                new ProfileModel { Name = "Rose King", ImagePath = "ProfileImage7.png" },
                new ProfileModel { Name = "Jeanette Bell", ImagePath = "ProfileImage9.png" },
                new ProfileModel { Name = "Lily Castro", ImagePath = "ProfileImage10.png" },
                new ProfileModel { Name = "Susie Moss", ImagePath = "ProfileImage11.png" },
                new ProfileModel { Name = "Rose King", ImagePath = "ProfileImage7.png" },
                new ProfileModel { Name = "Jeanette Bell", ImagePath = "ProfileImage9.png" },
                new ProfileModel { Name = "Lily Castro", ImagePath = "ProfileImage10.png" },
                new ProfileModel { Name = "Susie Moss", ImagePath = "ProfileImage11.png" }
            };

            this.Posts = new ObservableCollection<Model>()
            {
                new Model
                {
                    Title = "365 Days. 365 Words.",
                    Body = "After two years of writing, drafting, redrafting, rewriting, and editing, I have finally published my first collection of poetry— 365 Days. 365 Words. Each poem is unique in theme, but every single one is exactly 365 words. It’s been a challenging but also enjoyable journey, and it is my greatest hope that there is a poem in there that will resonate with every reader. Cheers!" +
                           "\n" + " " +
                           "\n" + "Also, many, many grateful thanks to Mr. Hunter and Ms. Brenda for being my gracious editors. I really appreciate it!" +
                           "\n" + " " +
                           "\n" + "You can order your copy on Amazon by clicking on the link below:" +
                           "\n" + " " +
                           "\n" + "www.amazon.com / 365 - Days - 365 - Words / dp / 006303249X / ref= zg_bs_10248_7 / 144 - 7879999 - 6214567 ? _encoding = UTF8 & psc = 1 & refRID = N1452 & 6P72YYS3XKN85L",
                    Author = new Member {
                        MemberId = 2,
                        FullName = "Nina Miller",
                        ProfilePhoto = new Photo
                            {
                                Url = "https://yakka.tech/images/356Days365Words.jpg",
                            }
                        },
                    CreatedAt = DateTime.Now.AddDays(-1).AddHours(-4).AddMinutes(-32),
                    ImagePath= "https://yakka.tech/images/356Days365Words.jpg",
                    FavoriteCount= 60
                },
                new Model
                {
                    Title = "Swan Lake",
                    Body = "I’m excited to present my dance school’s production of Swan Lake. This year, I’m grateful to have the lead role of Odette. Please come support us tonight at the Central City Theater @ 8 PM.",
                    Author = new Member {
                        MemberId = 3,
                        FullName = "Jill Booker",
                        ProfilePhoto = new Photo
                            {
                                Url = "https://yakka.tech/images/SwanLake.jpg",
                            }
                        },
                    CreatedAt = DateTime.Now.AddDays(-2).AddHours(-3).AddMinutes(-25),
                    ImagePath= "https://yakka.tech/images/SwanLake.jpg",
                    FavoriteCount= 250
                },

                new Model
                {
                    Title = "Music for the Soul",
                    Body = "Tonight we celebrate my favorite concert of the season— The Winter Holiday concert. This is by far the most complex and challenging concert of the year. We play pieces from all over the world, from East Asia to the Middle East, from Europe to Latin America. Not only does the variety of music challenge us to adopt different styles of playing, but it also opens our mind to the variety of the music in the world. It is truly an enlightening and intellectually engaging experience.",
                    Author = new Member {
                        MemberId = 1,
                        FullName = "Robert Smith",
                        ProfilePhoto = new Photo
                            {
                                Url = "https://yakka.tech/images/MusicForTheSoul.jpg",
                            }
                        },
                    CreatedAt = DateTime.Now.AddDays(-4).AddHours(-1).AddMinutes(-36),
                    ImagePath= "https://yakka.tech/images/MusicForTheSoul.jpg",
                    FavoriteCount= 90
                },

                new Model
                {
                    Title = "Blood, Sweat, and Tears",
                    Body = "Today was a rough day of training, but totally worth it for the upcoming meet. Every second I run is a moment well-spent. " +
                    "\n" + "Please come and support the Lowell Girls Team this Saturday, April 24, 2021. Go Jaguars!",
                    Author = new Member
                    {
                        MemberId = 1,
                        FullName = "Nina Miller" ,
                        ProfilePhoto = new Photo
                        {
                            Url = "https://yakka.tech/images/BloodSweatAndTears.jpg",
                        }

                    },
                    CreatedAt = DateTime.Now.AddDays(-4).AddHours(-3).AddMinutes(-1),
                    ImagePath = "https://yakka.tech/images/BloodSweatAndTears.jpg",
                    FavoriteCount = 227

                },


            };
        }
        #endregion

        #region Commands

        /// <summary>
        /// Gets or sets the command that is executed when the Follow button is clicked.
        /// </summary>
        public ICommand FollowCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the message button is clicked.
        /// </summary>
        public ICommand MessageCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the AddConnection button is clicked.
        /// </summary>
        public ICommand AddConnectionCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Image is tapped.
        /// </summary>
        public ICommand ImageTapCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the profile item is tapped.
        /// </summary>
        public ICommand ProfileSelectedCommand { get; set; }

        #endregion

        #region Properties

        public ObservableCollection<Model> Posts { get; set; }

        /// <summary>
        /// Gets or sets the interests collection.
        /// </summary>
        public ObservableCollection<ProfileModel> Interests
        {
            get
            {
                return this.interests;
            }

            set
            {
                this.interests = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the connections collection.
        /// </summary>
        public ObservableCollection<ProfileModel> Connections
        {
            get
            {
                return this.connnections;
            }

            set
            {
                this.connnections = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the photos collection.
        /// </summary>
        public ObservableCollection<ProfileModel> Pictures
        {
            get
            {
                return this.pictures;
            }

            set
            {
                this.pictures = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the header image path.
        /// </summary>
        public string HeaderImagePath
        {
            get { return App.BaseImageUrl + this.headerImagePath; }
            set { this.headerImagePath = value; }
        }

        /// <summary>
        /// Gets or sets the profile image.
        /// </summary>
        public string ProfileImage
        {
            get { return App.BaseImageUrl + this.profileImage; }
            set { this.profileImage = value; }
        }

        /// <summary>
        /// Gets or sets the background image.
        /// </summary>
        public string BackgroundImage
        {
            get { return App.BaseImageUrl + this.backgroundImage; }
            set { this.backgroundImage = value; }
        }

        /// <summary>
        /// Gets or sets the profile name
        /// </summary>
        public string ProfileName { get; set; }

        /// <summary>
        /// Gets or sets the designation
        /// </summary>
        public string Designation { get; set; }

        /// <summary>
        /// Gets or sets the state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the about
        /// </summary>
        public string About { get; set; }

        /// <summary>
        /// Gets or sets the posts count
        /// </summary>
        public int PostsCount { get; set; }

        /// <summary>
        /// Gets or sets the followers count
        /// </summary>
        public int FollowersCount { get; set; }

        /// <summary>
        /// Gets or sets the followings count
        /// </summary>
        public int FollowingCount { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the Follow button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void FollowClicked(object obj)
        {
            SfButton button = obj as SfButton;
            if (button.Text == "FOLLOW")
            {
                button.Text = "FOLLOWED";
            }
            else if (button.Text == "FOLLOWED")
            {
                button.Text = "FOLLOW";
            }
        }

        /// <summary>
        /// Invoked when the message button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void MessageClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the AddConnection button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void AddConnectionClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the Image is tapped.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void ImageClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the profile is tapped.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void ProfileClicked(object obj)
        {
            // Do something
        }

        #endregion
    }
}
