using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupMeal.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroupMeal.Pages
{
    //Remove buttons on listview, add hold recognizer for delete
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipePage : ContentPage
    {
        public ObservableCollection<recipe> Recipes { get; set; }
        public RecipePage()
        {
            InitializeComponent();

            this.Recipes = new ObservableCollection<recipe>();

            recipe salad = new recipe
            {
                listOfIngredients = "Peanuts, Cucumbers, Tomatoes",
                name = "Salad",
                directions = "Put them together",
                cookingTime = 11,
                cookingTimeUnit = "hours",
                image = "https://i.imgur.com/qeHLkzy.png",
                allergies = "Peanuts",
                recipeID = "1"


            };
            this.Recipes.Add(salad);



            this.recipeListView.ItemsSource = this.Recipes;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecipeEditPage());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecipePage());
        }

       

        private void recipeListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // make sure the selected item is not null
            if (e.SelectedItem == null)
            {
                return;
            }

            //grab the selected item as recipe class
            recipe selectedRecipe = e.SelectedItem as recipe;

            //deselect the item in the list
            (sender as ListView).SelectedItem = null;

            // send the recipe to the detail page
            Navigation.PushAsync(new RecipeOverviewPage(selectedRecipe));


        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            Recipes.Remove(Recipes.Where(x => x.recipeID == mi.CommandParameter.ToString()).FirstOrDefault());
            this.recipeListView.ItemsSource = this.Recipes;
        }

       
    }
}