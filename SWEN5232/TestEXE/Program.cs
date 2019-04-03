using System;
using System.Collections.Generic;
using System.Text;

namespace SWEN5232.TestEXE
{
    using SWEN5232.BusinessLayer;
    using SWEN5232.CrossLevel;
    using SWEN5232.DataLayer;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TestEXE: " + Location.Announce());

            Console.WriteLine("TestEXE: " + Size.Announce());

            Console.WriteLine("TestEXE: " + Record.Announce());

            Size s = new Size(1, 2, 4);

            Console.WriteLine("TestEXE: " + $"This is a test on a Size Object: { s.latitude } { s.longtitude } { s.altitude }");

            Console.ReadKey(true);
        }
    }
}
