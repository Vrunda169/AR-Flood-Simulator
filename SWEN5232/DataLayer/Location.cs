using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN5232.DataLayer
{
    public class Location
    {

        public Location(string lat, string longi, string alti)
        {
            latitude = lat;
            longitude = longi;
            altitude = alti;
        }

        public Location(string lat, string longi, string alti, string address)
        {
            latitude = lat;
            longitude = longi;
            altitude = alti;
            this.address = address;
        }

        public Location() { }

        private string latitude;
        private string longitude;
        private string altitude;
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Altitude
        {
            get { return altitude; }
            set { altitude = value; }
        }

        public string Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        public string Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

    }
}