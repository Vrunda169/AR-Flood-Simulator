using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN5232.DataLayer
{
    public class LocationDL
    {

        Location location;
        List<Location> locations;
        public LocationDL()
        {
            location = new Location
            {
                Address = "Rixos The Palm Dubai",
                Latitude = "25.1212",
                Longitude = "55.1535",
                Altitude = "XX"
            };
            SetDummyLocations();
        }
        /// <summary>
        /// Method to save the current location to firebase.
        /// </summary>
        /// <param name="locationData"></param>
        /// <returns></returns>
        public bool Set_currentlocation(Location locationData)
        {
            bool isSaved = false;
            if (locationData != null)
            {
                location = new Location();
                location.Address = locationData.Address;
                location.Latitude = locationData.Latitude;
                location.Longitude = locationData.Longitude;
                isSaved = true;
            }
            return isSaved;
        }

        /// <summary>
        /// Method to get the current location from firebase which was set by Set_currentlocation method.
        /// </summary>
        /// <returns>Location</returns>
        public Location Get_currentlocation()
        {
            return location;
        }

        /// <summary>
        /// Dummy method to save list of pre defined locations.
        /// </summary>
        /// <returns>Sets Dummy Location values</returns>
        public void SetDummyLocations()
        {
            locations = new List<Location>
            {
                new Location
                {
                    Address = "Rixos The Palm Dubai",
                    Latitude = "25.1212",
                    Longitude = "55.1535",
                    Altitude = "XX"
                },
                new Location
                {
                    Address = "Shangri-La Hotel",
                    Latitude = "25.2084",
                    Longitude = "55.2719",
                    Altitude = "XX"
                },
                new Location
                {
                    Address = "Grand Hyatt",
                    Latitude = "25.2285",
                    Longitude = "55.3273",
                    Altitude = "XX"
                },
                new Location
                {
                    Address = "151 East 77th Street, Manhattan, NY",
                    Latitude = "-73.9596265",
                    Longitude = "40.7736566",
                    Altitude = "XX"
                }
            };
        }

        /// <summary>
        /// Method to fetch the location and coordinates with address string.
        /// </summary>
        /// <returns>Location from the list</returns>
        public Location Get_Location(string address)
        {
            return locations.FindAll(x => x.Address.Contains(address)).FirstOrDefault();
        }
        public String Hello()
        {
            return "Hello from data layer";
        }
    }


}
