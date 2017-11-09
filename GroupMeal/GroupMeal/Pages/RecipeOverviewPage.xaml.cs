using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GroupMeal.Models;

namespace GroupMeal.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
   
    public partial class RecipeOverviewPage : ContentPage
    {
       
        public RecipeOverviewPage(recipe Recipe)
        {
            InitializeComponent();
            recipePicture.Source = Recipe.image;
            nameOfRecipe.Text = Recipe.name;

        }

        private void editButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecipeEditPage());
        }
    }
}