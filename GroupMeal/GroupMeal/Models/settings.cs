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

        private const string UserJson = "User";
        private static readonly string UserJsonDefault = "";

        private const string CategoryJson = "Category";
        private static readonly string CategoryJsonDefault = "";

        private const string FriendJson = "Friend";
        private static readonly string FriendJsonDefault = "";


        private const string RecipeJson = "Recipe";
        private static readonly string RecipeJsonDefault = "";

        private const string EventJson = "Event";
        private static readonly string EventJsonDefault = "";

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
                string data = AppSettings.GetValueOrDefault(RecipeJson, RecipeJsonDefault);
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
        public static List<@event> eventData
        {
            get
            {
                string data = AppSettings.GetValueOrDefault(EventJson, EventJsonDefault);
                if (String.IsNullOrEmpty(data))
                {
                    return null;
                }
                else
                {
                    return JsonConvert.DeserializeObject<List<@event>>(data);
                }
            }
            set
            {
                string data = JsonConvert.SerializeObject(value);
                AppSettings.AddOrUpdateValue(EventJson, data);
            }
        }

        public static List<Friend> friendData
        {
            get
            {
                string data = AppSettings.GetValueOrDefault(FriendJson, FriendJsonDefault);
                if (String.IsNullOrEmpty(data))
                {
                    return null;
                }
                else
                {
                    return JsonConvert.DeserializeObject<List<Friend>>(data);
                }
            }
            set
            {
                string data = JsonConvert.SerializeObject(value);
                AppSettings.AddOrUpdateValue(FriendJson, data);
            }
        }

     

    }
}
