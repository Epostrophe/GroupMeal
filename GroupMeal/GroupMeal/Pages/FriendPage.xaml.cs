using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            friend1.name = "Nathan Jordan";
            friend1.allergies = "apples";
            FriendsList.Add(friend1);

            Friend friend2 = new Friend();
            friend2.name = "Andrew Jordan";
            friend2.allergies = "bananas";
            FriendsList.Add(friend2);

            friendsListView.ItemsSource = this.FriendsList;
        }
    }
}