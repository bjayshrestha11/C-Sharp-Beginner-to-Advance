using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPRogramming
{
    
    public class Employee
    {
        // a.	Field Members: firstName, lastName, salary
        // string _firstName;
        // string _lastName;
        // float _salary;
        private  string _firstName;
        private  string _lastName;
        private  double _salary;

        // b.	Properties : FirstName, LastName, FullName, Salary
        public string FirstName { get => _firstName; set { _firstName = value; } }
        public string LastName { get => _lastName; set { _lastName = value; } }
        public double Salary { get => _salary; set { _salary = value; } }

        // c.	Parameterized Constructor

        public Employee(string firstName, string lastName, double salary)
        {
            _salary = salary;
            _lastName = lastName;
           _firstName = firstName;
        }
        // d.	Method: IncrementSalary(double s), Display() Method for showing details of employee
        public void IncrementSalary(double s)
        {
            _salary += s;
        }

        public void Display()
        {
            Console.WriteLine($"Full Name is {_firstName} {_lastName}");
            Console.WriteLine($"Salary is {_salary}");
        }

    }


    // Single Level Inheritance - Inheriting field

    public class Programmer
    {
        public string firstName = "Bijay";
        public string lastName = "Shrestha";
        public float bonus = 10000;
    }
    
}
