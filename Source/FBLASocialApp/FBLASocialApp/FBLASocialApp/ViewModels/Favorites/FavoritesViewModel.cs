using Xamarin.Forms;
using System.Collections.ObjectModel;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms.Internals;
using Model = SocialApi.Models.Post;
using SocialApi.Models;
using System;

namespace FBLASocialApp.ViewModels.Favorites
{
    /// <summary>
    /// ViewModel for Post card type page.
    /// </summary> 
    [Preserve(AllMembers = true)]
    public class FavoritesViewModel : BaseViewModel
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

        public FavoritesViewModel()
        {

            this.BookmarkCommand = new Command(this.BookmarkButtonClicked);
            this.AddFavouriteCommand = new Command(this.FavouriteButtonClicked);
            this.ShareCommand = new Command(this.ShareButtonClicked);

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
                                Url = "https://yakka.tech/images/NinaMiller.jpg",
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
                                Url = "https://yakka.tech/images/JillBooker.jpg",
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
                                Url = "https://yakka.tech/images/RobertSmith.jpg",
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
                            Url = "https://yakka.tech/images/NinaMiller.jpg",
                        }

                    },
                    CreatedAt = DateTime.Now.AddDays(-4).AddHours(-3).AddMinutes(-1),
                    ImagePath = "https://yakka.tech/images/BloodSweatAndTears.jpg",
                    FavoriteCount = 227

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
