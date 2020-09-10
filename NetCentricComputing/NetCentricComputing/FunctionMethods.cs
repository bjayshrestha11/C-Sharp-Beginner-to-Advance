using System;
using System.Collections.Generic;
using System.Text;

namespace NetCentricComputing
{
    class FunctionMethods
    {
        static void Main(string[] args)
        {
            // 4-Types
            /*
             ReturnType         Parameter
                0                   0   
                0                   1   
                1                   0   
                1                   1   
             */
            // Function Overloading
            //Type 1
            GetTitle();
            //Type 2
            Area(5);
            //Type 3
            Console.WriteLine($"The area of square is {Area()}");
            //Type 4
            Console.WriteLine($"The area of rectangle is {Area(10,5)}");
        }
        static void GetTitle()
        {
            Console.WriteLine("*************Calculate Area***************");
        }
        static void Area(int r)
        {
            Console.WriteLine($"The area of circle is {r*r}");
        }

        static int Area()
        {
            Console.Write("Enter the length: ");
            int a = Convert.ToInt32(Console.ReadLine());
            return a * a;
        }
        static int Area(int l, int b) => l * b;
        //{
        //    return l * b;
        //}
    }
}
