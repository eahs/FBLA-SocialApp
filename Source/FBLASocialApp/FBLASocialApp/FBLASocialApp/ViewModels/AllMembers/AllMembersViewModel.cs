using System;
using System.Collections.Generic;
using SocialApi.Models;
using SocialApi;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SocialApi.Response.v1;

namespace FBLASocialApp.ViewModels.AllMembers
{
    public class AllMembersViewModel : BaseViewModel
    {
        private List<int> participants;
        private Member selfParticipant;
        private int participant;
        private List<Member> memberList;
        

        public AllMembersViewModel()
        {
            this.GetAllMembersClickedCommand = new Command(this.GetAllMembersClicked);
        }

        public List<int> Participants
        {
            get
            {
                return this.participants;
            }

            set
            {
                this.participants = value;
                this.OnPropertyChanged("Participants");
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

        public int Participant
        {
            get
            {
                return this.participant;
            }

            set
            {
                this.participant = value;
                this.OnPropertyChanged("Participant");
            }
        }

        public List<Member> MemberList
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

        public Command CreateChatSessionCommand { get; set; }

        public Command GetAllMembersClickedCommand { get; set; }

        public async void CreateChatSessionClicked(List<int> participants)
        {
            if (IsBusy) return;

            IsBusy = true;

            await SocialApi.Chat.CreateChatSession(participants);
        }

        public async void GetAllMembersClicked(object obj)
        {
            if (IsBusy) return;

            IsBusy = true;

            ApiResponse<List<Member>> response = await Members.GetFriends();
            this.memberList = response.Result;
        }

        public async void CurrentMember()
        {

            if (IsBusy) return;

            IsBusy = true;

            ApiResponse<Member> response = await Members.GetMember();
            this.selfParticipant = response.Result;

        }


        public void MemberClicked(Member member)
        {
            this.participant = member.MemberId;
            this.participants.Add(selfParticipant.MemberId);
            this.participants.Add(participant);
            CreateChatSessionClicked(this.participants);
          
        }
    }
}