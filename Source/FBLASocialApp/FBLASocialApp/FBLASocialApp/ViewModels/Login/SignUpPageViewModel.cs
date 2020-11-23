using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using SocialApi;
using SocialApi.Response.v1;
using SocialApi.Models;

namespace FBLASocialApp.ViewModels.Login
{
    /// <summary>
    /// ViewModel for sign-up page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class SignUpPageViewModel : LoginViewModel
    {
        #region Fields

        private string firstName = "";

        private string lastName = "";

        private string password = "";

        private string confirmPassword = "";

        private DateTime birthday;

        private bool errorVisible = false;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="SignUpPageViewModel" /> class.
        /// </summary>
        public SignUpPageViewModel()
        {
            this.LoginCommand = new Command(this.LoginClicked);
            this.SignUpCommand = new Command(this.SignUpClicked);
        }

        #endregion

        #region Property

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the first name from user in the Sign Up page.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (this.firstName == value)
                {
                    return;
                }

                this.firstName = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the last name from user in the Sign Up page.
        /// </summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (this.lastName == value)
                {
                    return;
                }

                this.lastName = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the password from users in the Sign Up page.
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                if (this.password == value)
                {
                    return;
                }

                this.password = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the password from users in the Sign Up page.
        /// </summary>
        public string ConfirmPassword
        {
            get
            {
                return this.confirmPassword;
            }

            set
            {
                if (this.confirmPassword == value)
                {
                    return;
                }

                this.confirmPassword = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the password confirmation from users in the Sign Up page.
        /// </summary>
        public DateTime Birthday
        {
            get
            {
                return this.birthday;
            }

            set
            {
                if (this.birthday == value)
                {
                    return;
                }

                this.birthday = value;
                this.NotifyPropertyChanged();
            }
        }

        public bool ErrorIsVisible
        {
            get
            {
                return this.errorVisible;
            }

            set
            {
                this.errorVisible = value;
                OnPropertyChanged("ErrorIsVisible");
            }
        }

        #endregion

        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the Log In button is clicked.
        /// </summary>
        public Command LoginCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Sign Up button is clicked.
        /// </summary>
        public Command SignUpCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the Log in button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void LoginClicked(object obj)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        /// <summary>
        /// Invoked when the Sign Up button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void SignUpClicked(object obj)
        {
            if (Password == ConfirmPassword)
            {
                ApiResponse<Member> response = await Members.CreateMember(FirstName, LastName, Birthday, Email, Password);

                if (response.StatusCode == 200)
                {
                    ApiResponse<AuthenticateResponse> loginResponse = await YakkaApi.Current.Login(Email, Password);

                    if (loginResponse.StatusCode == 200)
                    {
                        await Shell.Current.GoToAsync("//HomePage");
                    }
                    else
                    {
                        ErrorMessage = loginResponse.ErrorMessage;
                        ErrorIsVisible = true;

                        Page p = obj as Page;
                        await p.DisplayAlert("Error", ErrorMessage, "OK");

                    }
                }
                else
                {
                    ErrorMessage = response.ErrorMessage;
                    ErrorIsVisible = true;

                    Page p = obj as Page;
                    await p.DisplayAlert("Error", ErrorMessage, "OK");
                }
            }
            else
            {
                ErrorMessage = "Passwords do not match";
                ErrorIsVisible = true;

                Page p = obj as Page;
                await p.DisplayAlert("Error", ErrorMessage, "OK");
            }

     
        }

        #endregion
    }
}