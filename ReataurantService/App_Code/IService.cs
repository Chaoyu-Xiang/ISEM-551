using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        List<Restaurant> GetRestaurantsList();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Restaurant
    {
        string name;
        string country;
        string city;
        string awardedSince;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        [DataMember]
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        [DataMember]
        public string AwardedSince
        {
            get { return awardedSince; }
            set { awardedSince = value; }
        }
    }