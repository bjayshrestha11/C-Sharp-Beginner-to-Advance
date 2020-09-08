using System;
using System.Collections.Generic;
using System.Text;

namespace NetCentricComputing
{
    class TypeCasting
    {
        static void Main(string[] args)
        {
            // Implicit Casting
            // char->int->long->float->double
            Console.WriteLine("---------Implicit Casting------------");
            char ch = 'C';
            int a = ch;
            long l = a;
            float f = l;
            double d = f;
            Console.WriteLine($" ch-{ch}\n a-{a}\n l-{l}\n f-{f}\n d-{d}\n");
            // Explicit Casting
            Console.WriteLine("---------Explicit Casting------------");
            int x = (int)3.4;
            float y = Convert.ToInt32(3.55);
            Console.WriteLine($"x is {x}\n y is {y}");

        }
    }
}
