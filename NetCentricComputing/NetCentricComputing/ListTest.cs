using System;
using System.Collections.Generic;
using System.Text;

namespace NetCentricComputing
{
    class ListTest
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("AK");
            names.Add("BS");
            names.Add("KS");
            names.Add("DK");
            Console.WriteLine($"The count is {names.Count}");
            Console.WriteLine("----------------------------");
            foreach (string item in names)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n----------------------------");


        }
    }
}
