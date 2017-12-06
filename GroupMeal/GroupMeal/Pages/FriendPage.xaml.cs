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

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (settings.friendData != null)
            {
                this.FriendsList = new ObservableCollection<Friend>(settings.friendData);

            }
            else
            {
                this.FriendsList = new ObservableCollection<Friend>();
            }
            this.friendsListView.ItemsSource = this.FriendsList;
        }
        public FriendPage()
        {
            InitializeComponent();

           
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new FriendEditPage());
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
            settings.friendData = this.FriendsList.ToList();
        }
    }
}