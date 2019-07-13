using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Models
{
    public class RestaurantInformation
    {
        [DisplayName("Name")]
        public string Name { get; set;}

        [DisplayName("Country")]
        public string Country { get; set; }

        [DisplayName("City")]
        public string City { get; set; }

        [DisplayName("AwardedSince")]
        public string AwardedSince { get; set; }
    }
}
