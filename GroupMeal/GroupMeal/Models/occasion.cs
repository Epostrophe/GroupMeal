using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMeal.Models
{
    class occasion
    {
        public DateTime time { get; set; }
        public string location { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public List<Friend> Friend { get; set; }
        public List<recipe> recipe { get; set; }

    } 
}
