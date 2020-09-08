using System;
using System.Collections.Generic;
using System.Text;

namespace NetCentricComputing
{
    class UserInput
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + name + " ! How are you? You are " + howAmI(age));
            Console.WriteLine($"Hello {name}! How are you? You are {howAmI(age)}");
            Console.WriteLine("Hello {0}! How are you? You are {1}", name, howAmI(age));
        }
        static string howAmI(int age) {
            if (age >= 12 && age < 23)
                return "young";
            else if (age >= 23)
                return "old";
            else
                return "child";
        }
    }
}
