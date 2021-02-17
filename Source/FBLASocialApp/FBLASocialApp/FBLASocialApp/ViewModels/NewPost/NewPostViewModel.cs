using Xamarin.Forms;
using System.Collections.ObjectModel;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms.Internals;
using SocialApi.Models;
using System;
using System.Threading.Tasks;
using SocialApi.Response.v1;
using System.Collections.Generic;
using SocialApi;

namespace FBLASocialApp.ViewModels.NewPost
{
    public class NewPostViewModel : BaseViewModel
    {
        private string postTitle;
        private string body;
        private PrivacyLevel privacyLevel = 0; // to be changed
        private bool isFeatured = false; // to be changed

        public NewPostViewModel()
        {
           this.CreatePostCommand = new Command(this.CreatePostClicked);
           

        }

        public string PostTitle
        {
            get
            {
                return this.postTitle;
            }

            set
            {
                if (this.postTitle == value)
                {
                    return;
                }

                this.postTitle = value;
                this.OnPropertyChanged("PostTitle");
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
                if (this.body == value)
                {
                    return;
                }

                this.body = value;
                this.OnPropertyChanged("Body");
            }
        }

        public Command CreatePostCommand { get; set; }

        
        private async void CreatePostClicked(object obj)
        {
            if (IsBusy) return;

            IsBusy = true;


            await Posts.CreatePost(postTitle, body, privacyLevel, isFeatured);
        }

        

    }
}