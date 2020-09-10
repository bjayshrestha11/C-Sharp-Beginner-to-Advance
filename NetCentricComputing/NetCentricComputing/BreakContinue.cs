using System;
using System.Collections.Generic;
using System.Text;

namespace NetCentricComputing
{
    class BreakContinue
    {
        static void Main(string[] args)
        {
            //  Break - means leave the loop forever
            Console.WriteLine("****************Break**************");
            for (int i = 0; i < 5; i++)
            {
                if (i!=3)
                {
                    Console.WriteLine($" i - {i}");
                }
                else
                {
                    break;
                }
            }
            // Continue - means leave this particular iteration of the loop
            Console.WriteLine("****************Continue**************");
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($" i - {i}");
                }
            }
        }
    }
}
