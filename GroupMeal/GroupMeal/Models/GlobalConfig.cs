using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMeal.Models
{
    public static class GlobalConfig
    {
        public static List<recipe> Recipes;

        public static void initialize()
        {
            Recipes = new List<recipe>();

            recipe salad = new recipe
            {
                listOfIngredients = "Peanuts, Cucumbers, Tomatoes",
                name = "Salad",
                directions = "Put them together",
                cookingTime = 11,
                cookingTimeUnit = "hours",
                image = "https://i.imgur.com/qeHLkzy.png",
                allergies = "Peanuts aaaaaaaa aaaaaaaaaaaaaaaa aaaaaaaaaaaaaaaaaaaaaaaaaa aaaaaaaaaaaa aaaaa aaaa aaaaaaaa aaaaaa aaaaaaaaaa aaaaaaa aaaaaaaaaaa aaaaaaaa aaaaaaaa aaaaaaa aaaaaaaaaa aaaa aaaaaaaa",
                recipeID = "1"


            };

            Recipes.Add(salad);

        }

            

    }
}
