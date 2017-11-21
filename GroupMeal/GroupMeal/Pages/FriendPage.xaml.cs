using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Friend> FriendsList { get; set; }

        public FriendPage()
        {
            InitializeComponent();

            this.FriendsList = new ObservableCollection<Friend>();

            Friend friend1 = new Friend();
            friend1.imageURL = "friends.jpg";
            friend1.firstName = "Nathan";
            friend1.lastName = "Jordan";
            friend1.Allergies.Add("apples");
            friend1.Allergies.Add("grapes");
            friend1.Allergies.Add("Pears");
            friend1.Dislikes.Add("fish");
            friend1.Likes.Add("fudge");
            FriendsList.Add(friend1);

            Friend friend2 = new Friend();
            friend2.imageURL = "friends.jpg";
            friend2.firstName = "Andrew";
            friend2.lastName = "Jordan";
            //friend2.Allergies.Add("bananas");
            friend2.Dislikes.Add("chicken");
            friend2.Likes.Add("ice cream");
            FriendsList.Add(friend2);

            Friend friend3 = new Friend();
            friend3.imageURL = "friends.jpg";
            friend3.firstName = "Kenton";
            friend3.lastName = "Hilderbrand";
            //friend3.Allergies.Add("oranges");
            //friend3.Dislikes.Add("beef");
            //friend3.Likes.Add("cookies");
            FriendsList.Add(friend3);

            friendsListView.ItemsSource = this.FriendsList;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FriendOverviewPage(friendsListView.SelectedItem as Friend));
        }

        private void friendsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            Friend selectedFriend = e.SelectedItem as Friend;
            (sender as ListView).SelectedItem = null;
            Navigation.PushAsync(new FriendOverviewPage(selectedFriend));
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            FriendsList.Remove(FriendsList.Where(x => x.friendID == mi.CommandParameter.ToString()).FirstOrDefault());
            this.friendsListView.ItemsSource = this.FriendsList;
        }
    }
}