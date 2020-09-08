using System;
using System.Collections.Generic;
using System.Text;

namespace NetCentricComputing
{
    class Operators
    {
        static void Main(string[] args)
        {
            // Assignment - =,+=,-=,*=,/=
            int a = 11;
            int b = 3;
            b += 2;
            b++;
            b -= 2;
            b--;
            b *= 1;
            b /= 1;
            // Arithmetic - +, -, *, /, % 
            var add = a + b;
            var sub = a - b;
            var mul = a * b;
            var div = a / b;
            var mod = a % b;
            //Comparison - ==, >,<,>=,<=,!=
            var eQuals = a == b;
            var greater = a > b;
            var less = a < b;
            var greatEqual = a >= b;
            var lessEqual = a <= b;
            var notEqual = a != b;
            //Logical
            var and = eQuals && less;
            var or = greatEqual || notEqual;
            var not = !eQuals;
            
        }
    }
}
