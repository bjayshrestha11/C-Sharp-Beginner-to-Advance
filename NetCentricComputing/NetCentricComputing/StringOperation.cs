using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCentricComputing
{
    class StringOperation
    {
        static void Main(string[] args)
        {
            string str = "I am a String";
            var length = str.Length;
            var up = str.ToUpper();
            var low = str.ToLower();
            var conCat = string.Concat(str," attached to it");
            var index = str.IndexOf("am");
            var subString = str.Substring(4);
            Console.WriteLine($" str - {str}\n length - {length}\n up - {up}\n");
            Console.WriteLine($" low - {low}\n concat - {conCat}\n index of \"am\" - {index}\n substring - {subString}");

        }
    }
}
