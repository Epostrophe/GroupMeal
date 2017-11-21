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
        public recipe recipeOnPage;
        public RecipeEditPage(recipe recipeOnPage = null)//finish passing recipe to this 
        {
            
            InitializeComponent();
            if(recipeOnPage != null)
            {
                recipeName.Text = recipeOnPage.name;
                ingredients.Text = recipeOnPage.listOfIngredients;
                directions.Text = recipeOnPage.directions;
                cookTime.Text = recipeOnPage.cookingTime.ToString();
                allergens.Text = recipeOnPage.allergies;
                servings.Text = recipeOnPage.servings.ToString();
                this.recipeOnPage = recipeOnPage;
            }
        }

        private void addRecipe_Clicked(object sender, EventArgs e)
        {
            List<recipe> Recipes = settings.recipesData;

            if (Recipes == null)
            {
                Recipes = new List<recipe>();
            }

            if (recipeOnPage != null)
            {
                recipe recipeToUpdate = Recipes.Where(rec => rec.recipeID == recipeOnPage.recipeID).First();
                recipeToUpdate.name = recipeName.Text;
                recipeToUpdate.allergies = allergens.Text;
                recipeToUpdate.cookingTime = Convert.ToInt32(cookTime.Text);
                recipeToUpdate.directions = directions.Text;
                recipeToUpdate.listOfIngredients = ingredients.Text;
                recipeToUpdate.servings = Convert.ToInt32(servings.Text);
            }
            else
            {
                recipeOnPage = new recipe();

                recipeOnPage.name = recipeName.Text;
                
                recipeOnPage.recipeID = Guid.NewGuid().ToString();
                Recipes.Add(recipeOnPage);
            }
           

            

           

            settings.recipesData = Recipes;
            Navigation.PopAsync();
        }
    }
}