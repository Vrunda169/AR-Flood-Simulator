using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// User Interface Layer
/// </summary>
namespace SWEN5232.OurConsole
{
    using SWEN5232.BusinessLayer;
    using SWEN5232.CrossLevel;
    using SWEN5232.DataLayer;

    class MainEntry
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Location.Announce());

            Console.WriteLine(Size.Announce());

            Console.WriteLine(Record.Announce());

            Size s = new Size(1, 2, 4);

            Console.WriteLine($"This is a test on a Size Object: { s.latitude } { s.longtitude } { s.altitude }");

            Console.ReadKey(true);
        }
    }
}
