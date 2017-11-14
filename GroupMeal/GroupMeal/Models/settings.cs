using Newtonsoft.Json;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMeal.Models
{
    class settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        private const string UserJson = "";
        private static readonly string UserJsonDefault = "";

        private const string CategoryJson = "";
        private static readonly string CategoryJsonDefault = "";

        private const string FriendJson = "";
        private static readonly string FriendJsonDefault = "";

        private const string OccasionJson = "";
        private static readonly string OccasionDefault = "";

        private const string RecipeJson = "";
        private static readonly string RecipeDefault = "";

        public static category categoryData
        {
            get
            {
                string data = AppSettings.GetValueOrDefault(CategoryJson, CategoryJsonDefault);
                if (String.IsNullOrEmpty(data))
                {
                    return null;
                }
                else
                {
                    return JsonConvert.DeserializeObject<category>(data);
                }
            }
            set
            {
                string data = JsonConvert.SerializeObject(value);
                AppSettings.AddOrUpdateValue(CategoryJson, data);
            }
        }

        public static List<recipe> recipesData
        {
            get
            {
                string data = AppSettings.GetValueOrDefault(RecipeJson, RecipeDefault);
                if (String.IsNullOrEmpty(data))
                {
                    return null;
                }
                else
                {
                    return JsonConvert.DeserializeObject<List<recipe>>(data);
                }
            }
            set
            {
                string data = JsonConvert.SerializeObject(value);
                AppSettings.AddOrUpdateValue(RecipeJson, data);
            }
        }

    }
}
