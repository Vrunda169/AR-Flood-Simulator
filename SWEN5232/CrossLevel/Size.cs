using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN5232.CrossLevel
{
    public class Size
    {
        public static string Announce() => "CrossLevel: Size";

        public int latitude { get; set; }
        public int longtitude { get; set; }

        public int altitude { get; set; }

        public Size(int lat, int lon, int alt = 0)
        {
            latitude = lat;
            longtitude = lon;
            altitude = alt;
        }

    }
}
