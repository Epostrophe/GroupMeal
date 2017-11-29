using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            nameLabel.Text = friend.fullName;

            allergiesListView.ItemsSource = friend.Allergies;

            selectedFriend = friend;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            selectedFriend.Allergies.Remove(selectedFriend.Allergies.Where(x => x == mi.CommandParameter.ToString()).FirstOrDefault());
            this.allergiesListView.ItemsSource = this.selectedFriend.Allergies;
        }

        private void allergiesListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
        }
    }
}