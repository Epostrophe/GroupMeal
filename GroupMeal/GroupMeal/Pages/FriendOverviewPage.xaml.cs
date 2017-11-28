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
        public FriendOverviewPage(Friend friend)
        {
            InitializeComponent();

            friendImage.Source = friend.imageURL;
            nameLabel.Text = friend.fullName;

            allergiesListView.ItemsSource = friend.Allergies;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }

        private void allergiesListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}