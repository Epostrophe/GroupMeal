using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupMeal.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GroupMeal.Models;


namespace GroupMeal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendOverviewPage : ContentPage
    {
        public Friend selectedFriend;
        public FriendOverviewPage(Friend friend)
        {
            InitializeComponent();

            friendImage.Source = friend.imageURL;
            firstNameLabel.Text = friend.firstName;
            lastNameLabel.Text = friend.lastName;
            likesLabel.Text = friend.likes;
            dislikesLabel.Text = friend.dislikes;
            allergiesLabel.Text = friend.allergies;
            //nameLabel.Text = friend.fullName;



            selectedFriend = friend;
        }

        private void editButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FriendEditPage(selectedFriend));
        }




        //private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{

        //}

    }
}