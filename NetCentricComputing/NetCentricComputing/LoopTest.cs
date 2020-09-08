using System;
using System.Collections.Generic;
using System.Text;

namespace NetCentricComputing
{
    class LoopTest
    {
        static void Main(string[] args)
        {
            // for loop
            ForLoop();
            // while loop
            WhileLoop();
            // do while loop
            DoWhileLoop();
            // foreach
            ForEachLoop();
        }

        
        static void WhileLoop()
        {
            Console.WriteLine("************While Loop************");
            int i = 0;
            while (i<=10)
            {
                Console.WriteLine($" i is {i}");
                i++;
            }
        }
        static void DoWhileLoop()
        {
            Console.WriteLine("************Do While Loop************");
            int i = 0;
            do
            {
                Console.WriteLine($" i is {i}");
                i++;
            } while (i >= 10);
        }
        static void ForLoop()
        {
            Console.WriteLine("************For Loop************");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($" i is {i}");
            }
        }
        static void ForEachLoop()
        {
            Console.WriteLine("************ForEach Loop************");
            Console.WriteLine("Looping array of integer");
            int[] list = {1,2,3,4,5,6};
            foreach (int item in list)
            {
                Console.Write($"{item}\t\t");
            }
            Console.WriteLine("\nThe Fruits are:");
            string[] fruits = {"Mango","Banana","Apple","Orange","Grapes"};
            foreach (string fruit in fruits)
            {
                Console.Write($"{fruit}\t\t");
            }
        }
    }
}
