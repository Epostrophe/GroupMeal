namespace GroupMeal.Models
{
    public class Friend
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get { return firstName + " " + lastName; } }
        public string likes { get; set; }
        public string dislikes { get; set; }
        public string allergies { get; set; }
        public string imageURL { get; set; }
        public string friendID { get; set; }
        public string displayPreferences
        {
            get
            {
                if (!string.IsNullOrEmpty(allergies))
                {
                    return allergies;
                }
                else if (!string.IsNullOrEmpty(dislikes))
                {
                    return dislikes;
                }
                else if (!string.IsNullOrEmpty(likes))
                {
                    return likes;
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