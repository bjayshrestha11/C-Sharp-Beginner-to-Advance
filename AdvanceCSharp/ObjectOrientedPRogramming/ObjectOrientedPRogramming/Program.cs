using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPRogramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Oriented Programming
            /*
             * Class & Object
             * Attributes of class - Fields
             * Constructor
             * Methods
             * Getter Setter
             * static class attributes / methods
             * Abstract Class
             * Inheritance
             * Polymorphism
             */
            //Console.WriteLine("Learn OOP in C#");
            // i.	Constructor
            Employee e1 = new Employee("Bijaya", "Shrestha", 10000);
            // ii.	Display the Full Name and Salary using Properties
            Console.WriteLine($"Full Name is {e1.FirstName} {e1.LastName}");
            Console.WriteLine($"Salary is {e1.Salary}");
            // iii.	Change the First Name
            e1.FirstName = "Bijay";
            Console.WriteLine($"First Name is changed as {e1.FirstName}");
            // iv.	Increment the Salary by 10%
            double incSal = 0.1 * e1.Salary;
            e1.IncrementSalary(incSal);
            Console.WriteLine($"After increment by 10% salary is {e1.Salary}");
            // v.	Display Full Name and Salary by calling method.
            e1.Display();
            Console.ReadKey();
        }
    }
}
