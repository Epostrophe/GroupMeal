using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupMeal.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroupMeal.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeEditPage : ContentPage
    {
        
        public RecipeEditPage()//finish passing recipe to this 
        {
            
            InitializeComponent();
        }

        private void addRecipe_Clicked(object sender, EventArgs e)
        {
            recipe newRecipe = new recipe();

            newRecipe.name = recipeName.Text;
            newRecipe.allergies = allergens.Text;
            newRecipe.cookingTime = Convert.ToInt32(cookTime.Text);
            newRecipe.directions = directions.Text;
            newRecipe.listOfIngredients = ingredients.Text;
            newRecipe.servings = Convert.ToInt32(servings.Text);
            newRecipe.recipeID = Guid.NewGuid().ToString();

            List<recipe> Recipes = settings.recipesData;

            if(Recipes == null)
            {
                Recipes = new List<recipe>();
            }

            Recipes.Add(newRecipe);

            settings.recipesData = Recipes;
            Navigation.PopAsync();
        }
    }
}