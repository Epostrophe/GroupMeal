using System.Collections.ObjectModel;

namespace GroupMeal.Models
{
    public class Friend
    {
        public Friend()
        {
            firstName = "";
            lastName = "";
            imageURL = "";
            friendID = "";
            this.Likes = new ObservableCollection<string>();
            this.Dislikes = new ObservableCollection<string>();
            this.Allergies = new ObservableCollection<string>();
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get { return firstName + " " + lastName; } }
        public string imageURL { get; set; }
        public string friendID { get; set; }

        public ObservableCollection<string> Likes { get; set; }
        public string likes
        {
            get
            {
                string likesList = "";
                foreach(var like in Likes)
                {
                    likesList += like + ", ";
                }
                if (likesList == "")
                {
                    return likesList;
                }
                else
                {
                    return likesList.Substring(0, likesList.Length - 2);
                }
            }
        }
        public ObservableCollection<string> Dislikes { get; set; }
        public string dislikes
        {
            get
            {
                string dislikesList = "";
                foreach(var dislike in Dislikes)
                {
                    dislikesList += dislike + ", ";
                }
                if (dislikesList == "")
                {
                    return dislikesList;
                }
                else
                {
                    return dislikesList.Substring(0, dislikesList.Length - 2);
                }
            }
        }
        public ObservableCollection<string> Allergies { get; set; }
        public string allergies
        {
            get
            {
                string allergiesList = "";
                foreach(var allergy in Allergies)
                {
                    allergiesList += allergy + ", ";
                }
                if (allergiesList == "")
                {
                    return allergiesList;
                }
                else
                {
                    return allergiesList.Substring(0, allergiesList.Length - 2);
                }
            }
        }
        public string displayPreferences
        {
            get
            {
                if (!string.IsNullOrEmpty(allergies))
                {
                    return "Allergies: " + allergies;
                }
                else if (!string.IsNullOrEmpty(dislikes))
                {
                    return "Dislikes: " + dislikes;
                }
                else if (!string.IsNullOrEmpty(likes))
                {
                    return "Likes: " + likes;
                }
                else
                {
                    string noDataMessage = "No data on this person's preferences";
                    return noDataMessage;
                }
            }
        }
    }
}