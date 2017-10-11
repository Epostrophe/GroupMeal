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
    public partial class TitlePage : ContentPage
    {
        public TitlePage()
        {
            InitializeComponent();
        }


        private void friendButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FriendPage());
        }

        private void recipeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecipePage());
        }

        private void eventButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventPage());
        }
    }
}