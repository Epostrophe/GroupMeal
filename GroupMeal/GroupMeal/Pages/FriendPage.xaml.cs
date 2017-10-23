using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GroupMeal.Models;

namespace GroupMeal.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class FriendPage : ContentPage
    {
        public List<Friend> FriendsList { get; set; }

        public FriendPage()
        {
            InitializeComponent();

            this.FriendsList = new List<Friend>();

            Friend friend1 = new Friend();
            friend1.imageURL = "friends.jpg";
            friend1.firstName = "Nathan";
            friend1.lastName = "Jordan";
            friend1.allergies = "apples";
            FriendsList.Add(friend1);

            Friend friend2 = new Friend();
            friend2.imageURL = "friends.jpg";
            friend2.firstName = "Andrew";
            friend2.lastName = "Jordan";
            friend2.allergies = "bananas";
            FriendsList.Add(friend2);

            Friend friend3 = new Friend();
            friend3.imageURL = "friends.jpg";
            friend3.firstName = "Kenton";
            friend3.lastName = "Hilderbrand";
            friend3.allergies = "oranges";
            FriendsList.Add(friend3);

            friendsListView.ItemsSource = this.FriendsList;
        }

        private void editButton_Clicked(object sender, EventArgs e)
        {

        }

        private void removePersonButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}