using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NetCentricComputing
{
    class ArrayListTest
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            object obj = "A!";
            arr.Add("S1");
            arr.Add(1);
            arr.Add(3.4);
            arr.Add(obj);

            string s1 = (string)arr[0];
            int n1 = (int)arr[1];
            Console.WriteLine("----------------------------");
            foreach (Object item in arr)
            {
                Console.WriteLine($"arr[] - {item}");
            }
            Console.WriteLine("----------------------------");
            
            Console.WriteLine(arr.Count);
            Console.WriteLine(arr.IndexOf(obj));
            arr.Remove("S1");
            arr.RemoveAt(2);
            Console.WriteLine("----------------------------");
            foreach (Object item in arr)
            {
                Console.WriteLine($"arr[] - {item}");
            }
            Console.WriteLine("----------------------------");

        }
    }
}
