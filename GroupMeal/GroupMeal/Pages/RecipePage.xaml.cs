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
                image = "http://www.inspiredtaste.net/wp-content/uploads/2016/06/Avocado-Egg-Salad-Recipe-1-1200.jpg"


            };
            this.Recipes.Add(salad);



            this.recipeListView.ItemsSource = this.Recipes;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {

        }
    }
}