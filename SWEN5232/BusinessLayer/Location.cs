using SWEN5232.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN5232.BusinessLayer
{
    public class LocationBL
    {
        public LocationDL locationBusinessLayer;
        /// <summary>
        /// Method to get a new location
        /// </summary>
        /// <returns>Location</returns>
        public LocationBL()
        {
            locationBusinessLayer = new LocationDL();
        }
        /// <summary>
        /// Sets the values to get a new location 
        /// </summary>
        /// <param name="address"></param>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        /// <returns>New location</returns>
        public bool Set_currentlocation(string address, string longitude, string latitude)
        {
            Location l = new Location();
            l.Address = address;
            l.Longitude = longitude;
            l.Latitude = latitude;
            return locationBusinessLayer.Set_currentlocation(l);
        }
        /// <summary>
        /// Gets the current location 
        /// </summary>
        /// <returns>Current Location</returns>
        public Location Get_currentlocation()
        {
            return locationBusinessLayer.Get_currentlocation();
        }

        /// <summary>
        /// Gets the entered location 
        /// </summary>
        /// <param name="address"></param>
        /// <returns>Location</returns>
        public Location Get_Location(string address)
        {
            return locationBusinessLayer.Get_Location(address);
        }
    }
}