using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataLayer;
using System.Data;


namespace BusinessLayer
{
    public class RestaurantList
    {
        public static List<RestaurantInformation> GetRestaurantDate()
        {
            RestaurantInformation dataEntry = new RestaurantInformation();
            var dataEntryList = new List<RestaurantInformation>();

            DataSet ds = new DataSet();

            //2nd assignment
            //ds = RestaurantDbAccess.GetDataUsingDB();

            //3rd assignment
            var service = new RestaurantService.RestaurantServiceClient();

            ds = service.GetDataUsingDB();

            if (ds.Tables.Count > 0)
            {
                dataEntryList = ds.Tables[0].AsEnumerable().Select(m => new RestaurantInformation
                {
                    Name = Convert.ToString(m["Name"]),
                    Country = Convert.ToString(m["Country"]),
                    City = Convert.ToString(m["City"]),
                    AwardedSince = Convert.ToString(m["AwardedSince"])
                }).ToList();
            }

            return dataEntryList;

        }
    }

       
}
