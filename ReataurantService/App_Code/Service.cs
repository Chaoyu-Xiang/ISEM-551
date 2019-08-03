using System;
using System.Collections.Generic;
using Models;
using BusinessLayer;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
    {
        public List<Restaurant> GetRestaurantsList()
        {
            List<Restaurant> returnList = new List<Restaurant>();
            List<RestaurantInformation> dataList = RestaurantList.GetRestaurantData();
            foreach (RestaurantInformation item in dataList)
            {
                Restaurant rest = new Restaurant(); 
                rest.Name = item.Name;
                rest.Country = item.Country;
                rest.City = item.City;
                rest.AwardedSince = item.AwardedSince;
                returnList.Add(rest);
            }
            return returnList;
        }
    }
