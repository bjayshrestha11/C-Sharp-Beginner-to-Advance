using System;
using System.Collections.Generic;
using System.Text;

namespace NetCentricComputing
{
    class DataTypesVariables
    {
        static void Main(string[] args)
        {
            var a = 24;         // Takes a data type defined in right side value
            int x = 10;         // Integer
            float y = 30.48F;   // Float
            char ch = 'A';      // Character
            bool isEasy = true; // Boolean
            string str = "Aistha";      // String
            long z = 123456666;         // Long
            double d = 23409.353453;    // Double
            double dd = 23234409.353453D;
            Console.WriteLine($"var {a}\n int {x}\n float {y}\n char {ch}\n bool {isEasy}\n string {str}\n long {z}\n");
            Console.WriteLine($"double {d}\n double {dd}");
            Console.ReadLine();
        }
    }
}
