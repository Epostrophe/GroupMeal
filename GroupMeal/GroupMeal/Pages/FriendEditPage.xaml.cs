using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupMeal.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroupMeal.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendEditPage : ContentPage
    {
        public Friend selectedFriend;
        public FriendEditPage(Friend selectedFriend = null)
        {
            InitializeComponent();
            if(selectedFriend != null)
            {
                firstName.Text = selectedFriend.firstName;
                lastName.Text = selectedFriend.lastName;
                likes.Text = selectedFriend.likes;
                dislikes.Text = selectedFriend.dislikes;
                allergies.Text = selectedFriend.allergies;
                this.selectedFriend = selectedFriend;
            }
        }

        private void addFriend_Clicked(object sender, EventArgs e)
        {
            List<Friend> Friend = settings.friendData;

            if(Friend == null)
            {
                Friend = new List<Friend>();
            }
            if(selectedFriend != null)
            {
                Friend friendToUpdate = Friend.Where(rec => rec.friendID == selectedFriend.friendID).First();
                friendToUpdate.firstName = firstName.Text;
                friendToUpdate.lastName = lastName.Text;
                friendToUpdate.likes = likes.Text;
                friendToUpdate.dislikes = dislikes.Text;
                friendToUpdate.allergies = allergies.Text;
            }
            else
            {
                selectedFriend = new Friend();
                selectedFriend.firstName = firstName.Text;
                selectedFriend.lastName = lastName.Text;
                selectedFriend.likes = likes.Text;
                selectedFriend.dislikes = dislikes.Text;
                selectedFriend.allergies = allergies.Text;

                selectedFriend.friendID = Guid.NewGuid().ToString();
                Friend.Add(selectedFriend);
            }
            settings.friendData = Friend;
            Navigation.PopAsync();
        }
    }
}