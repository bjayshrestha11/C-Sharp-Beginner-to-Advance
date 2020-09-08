using System;
using System.Collections.Generic;
using System.Text;

namespace NetCentricComputing
{
    class MathTest
    {
        static void Main(string[] args)
        {
            var a = Math.Min(11,111);
            var b = Math.Max(25,234);
            var c = Math.Sqrt(36);
            var d = Math.Abs(-23);
            Console.WriteLine($" a - {a}\n b - {b}\n c - {c}\n d - {d}\n");
            //Others
            /*
             * Math.Floor(x)
             * Math.Ceiling(y)
             * Math.Pow(x,y)
             * Math.Round(d)
             * Math.Sin(a)
             * Math.Cos(a)
             * Math.Tan(a)
             * and .................many more Explore
             */
            
        }
    }
}
