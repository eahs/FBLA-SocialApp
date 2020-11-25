using Xamarin.Forms;
using System.Collections.ObjectModel;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms.Internals;
using Model = SocialApi.Models.Post;
using SocialApi.Models;
using System;

namespace FBLASocialApp.ViewModels.Home
{
    /// <summary>
    /// ViewModel for Post card type page.
    /// </summary> 
    [Preserve(AllMembers = true)]
    public class FeedViewModel : BaseViewModel
    {
        #region Fields

        private Command<object> itemTappedCommand;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets a collction of value to be displayed in articles card page.
        /// </summary>
        public ObservableCollection<Model> Posts { get; set; }

        /// <summary>
        /// Gets the command that will be executed when an item is selected.
        /// </summary>
        public Command<object> ItemTappedCommand
        {
            get
            {
                return this.itemTappedCommand ?? (this.itemTappedCommand = new Command<object>(this.NavigateToNextPage));
            }
        }

        #endregion

        #region Constructor

        public FeedViewModel()
        {

            this.BookmarkCommand = new Command(this.BookmarkButtonClicked);
            this.AddFavouriteCommand = new Command(this.FavouriteButtonClicked);
            this.ShareCommand = new Command(this.ShareButtonClicked);

            this.Posts = new ObservableCollection<Model>()
            {
                new Model
                {
                    Title = "Lowell High School State-Wide Hackathon ",
                    Body = "Today, my team and I participated in our school’s most famous hackathon and competed with several teams from the state. We made 1st place with a cash price of $500! A big thanks to Lisa, Miles, and Johnathan. Thank you for your dedication to practices for these last several months.",
                    Author = new Member {
                        MemberId = 1,
                        FullName = "Robert Smith",
                        ProfilePhoto = new Photo
                            {
                                Url = App.BaseImageUrl + "RobertSmith.jfif"
                            }
                        },
                    CreatedAt = DateTime.Now,
                    ImagePath= App.BaseImageUrl + "Hackathon.jpg",
                    FavoriteCount= 100
                },
                new Model
                {
                    Title = "Holistic Approach to UI Design",
                    Body = "",
                    Author = new Member {
                        MemberId = 1,
                        FullName = "John Doe",
                        ProfilePhoto = new Photo
                            {
                                Url = App.BaseImageUrl + "ProfileImage12.png"
                            }
                        },
                    CreatedAt = DateTime.Now,
                    ImagePath= App.BaseImageUrl + "Event-Image.png",
                    FavoriteCount= 60
                },
                new Model
                {
                    Title = "Learning to Reset",
                    Body = "",
                    Author = new Member {
                        MemberId = 1,
                        FullName = "John Doe",
                        ProfilePhoto = new Photo
                            {
                                Url = App.BaseImageUrl + "ProfileImage1.png"
                            }
                        },
                    CreatedAt = DateTime.Now,
                    ImagePath= App.BaseImageUrl + "ArticleImage2.png",
                    FavoriteCount= 250
                },
                new Model
                {
                    Title = "Music",
                    Body = "",
                    Author = new Member {
                        MemberId = 1,
                        FullName = "John Doe",
                        ProfilePhoto = new Photo
                            {
                                Url = App.BaseImageUrl + "ProfileImage2.png"
                            }
                        },
                    CreatedAt = DateTime.Now,
                    ImagePath= App.BaseImageUrl + "ArticleImage7.jpg",
                    FavoriteCount= 350
                },
                new Model
                {
                    Title = "Guiding Your Flock to Success",
                    Body = "",
                    Author = new Member {
                        MemberId = 1,
                        FullName = "John Doe",
                        ProfilePhoto = new Photo
                            {
                                Url = App.BaseImageUrl + "ProfileImage5.png"
                            }
                        },
                    CreatedAt = DateTime.Now,
                    ImagePath= App.BaseImageUrl + "ArticleImage4.png",
                    FavoriteCount= 90
                },

            };
        }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when an item is selected from the articles card list page.
        /// </summary>
        /// <param name="selectedItem">Selected item from the list view.</param>
        private void NavigateToNextPage(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the favourite button clicked
        /// </summary>
        /// <param name="obj">The object</param>
        private void FavouriteButtonClicked(object obj)
        {
            if (obj != null && (obj is Model))
            {
                (obj as Model).IsFavorite = (obj as Model).IsFavorite ? false : true;
            }
            else
            {
                var button = obj as SfButton;
                if (button != null)
                {
                    button.Text = (button.Text == "\ue701") ? "\ue732" : "\ue701";
                }
            }
        }

        public void BookmarkButtonClicked(object obj)
        {
            /*
            if (obj != null && (obj is Model))
            {
                (obj as Model).IsBookmarked = (obj as Model).IsBookmarked ? false : true;
            }
            else
            {
                var button = obj as SfButton;
                if (button != null)
                {
                    button.Text = (button.Text == "\ue72f") ? "\ue734" : "\ue72f";
                }
            }
            */
        }

        private void ShareButtonClicked(object obj)
        {
            // Do Something.
        }
        #endregion

        #region commands

        /// <summary>
        /// Gets or sets the command is executed when the bookmark button is clicked.
        /// </summary>
        public Command BookmarkCommand { get; set; }

        /// <summary>
        /// Gets or sets the command is executed when the favourite button is clicked.
        /// </summary>
        public Command AddFavouriteCommand { get; set; }

        /// <summary>
        /// Gets or sets the command is executed when the share button is clicked.
        /// </summary>
        public Command ShareCommand { get; set; }

        #endregion
    }
}
