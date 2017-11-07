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

            Friend friend1 = new Friend();
            friend1.imageURL = "friends.jpg";
            friend1.firstName = "Nathan";
            friend1.lastName = "Jordan";
            friend1.allergies = "apples";

            friendImage.Source = friend1.imageURL;
            nameLabel.Text = friend1.fullName;
        }
    }
}