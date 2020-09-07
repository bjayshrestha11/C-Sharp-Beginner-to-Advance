using System;
using System.Collections.Generic;
using System.Text;

namespace NetCentricComputing
{
    class EnumTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Sunday);
            int day = (int)WeekDays.Monday;
            Console.WriteLine(day);
            var w = (WeekDays)6;
            Console.WriteLine(w);
        }
        enum WeekDays { 
            Sunday = 1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday

        }
    }
    
}
