using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GroupMeal.Models
{
    public class recipe
    {
        public string listOfIngredients { get; set; }
        public string name { get; set; }
        public string directions { get; set; }
        public int cookingTime { get; set; }
        public string cookingTimeUnit { get; set; } 
        public string descriptions { get; set; }
        public string image { get; set; }
    }
}
