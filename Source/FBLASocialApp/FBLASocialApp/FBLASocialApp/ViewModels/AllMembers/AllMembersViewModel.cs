using System;
using System.Collections.Generic;
using SocialApi.Models;
using SocialApi;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SocialApi.Response.v1;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FBLASocialApp.ViewModels.AllMembers
{
    public class AllMembersViewModel : BaseViewModel
    {
        private Member selfParticipant;
        private ObservableCollection<Member> memberList;
        public ObservableCollection<Member> participantList;



        public AllMembersViewModel()
        {
            this.MemberClickedCommand = new Command(this.MemberClicked);

            memberList = new ObservableCollection<Member>();


        }

        protected override async Task LoadItemsAsync()
        {
            // Basic pattern
            try
            {



                // Make async request to obtain data
                ApiResponse<List<Member>> response = await Members.GetFriends();

                if (response.ErrorCount == 0)
                {
                    IsError = false;
                    DataAvailable = true;

                    //this.memberList = new ObservableCollection<Member>(response.Result);
                    foreach (var member in response.Result)
                    {
                        MemberList.Add(member);
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

        public ObservableCollection<Member> MemberList
        {
            get
            {
                return this.memberList;
            }

            set
            {
                this.memberList = value;
                this.OnPropertyChanged("MemberList");
            }
        }

        public ObservableCollection<Member> ParticipantList
        {
            get
            {
                return this.participantList;
            }

            set
            {
                this.participantList = value;
                this.OnPropertyChanged("ParticipantList");
            }
        }

        public Command MemberClickedCommand { get; set; }



        public async void MemberClicked()
        {
            if (IsBusy) return;

            IsBusy = true;

            var chatlist = memberList.Select(m => m.MemberId).ToList();

            if (!chatlist.Contains(selfParticipant.MemberId))
            {
                chatlist.Add(selfParticipant.MemberId);
            }


            await SocialApi.Chat.CreateChatSession(chatlist);

            await Shell.Current.GoToAsync("//Yakka/Chat/Session?sessionId=30");


            IsBusy = false;

        }

        public void CreateParticipantList()
        {
            ParticipantList = this.memberList;
        }

    }
}