using System;
using System.Collections.Generic;
using System.Text;

namespace NetCentricComputing
{
    class DecisionConditional
    {
        static void Main(string[] args)
        {

            // if/else
            IfElse();
            // if/else if ladder
            IfElseIf();
            //switch
            SwitchCase();
        }

        static void IfElse()
        {
            Console.WriteLine("************Even or Odd Example*************");
            Console.Write("Enter number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
                Console.WriteLine($"{a} is Even");
            else
                Console.WriteLine($"{a} is Odd");
        }
        static void IfElseIf()
        {
            Console.WriteLine("************Which Day Example*************");
            Console.Write("Enter day in number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a==1)
                Console.WriteLine("Today is Sunday");
            if (a == 2)
                Console.WriteLine("Today is Monday");
            if (a == 3)
                Console.WriteLine("Today is Tuesday");
            if (a == 4)
                Console.WriteLine("Today is Wednesday");
            if (a == 5)
                Console.WriteLine("Today is Thursday");
            if (a == 6)
                Console.WriteLine("Today is Friday");
            if (a == 7)
                Console.WriteLine("Today is Saturday");
            else
                Console.WriteLine("Out of Syllabus.");
        }

        static void SwitchCase() 
        {
            Console.WriteLine("************Calculator Example*************");
            int a, b;
            Console.Write("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Perform: ");
            char op = Console.ReadKey().KeyChar;
            switch(op)
            {
                case '+':
                    Console.WriteLine($"\nAns is {a+b}");
                    break;
                case '-':
                    Console.WriteLine($"\nAns is {a-b}");
                    break;
                case '*':
                    Console.WriteLine($"\nAns is {a*b}");
                    break;
                case '/':
                    Console.WriteLine($"\nAns is {a/b}");
                    break;
                case '%':
                    Console.WriteLine($"\nAns is {a%b}");
                    break;
                default:
                    Console.WriteLine("\nInvalid Operation!!!.");
                    break;
            }

        }
    }
}
