using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable Declartion
            int x, y, z, a, b;

            //Assignment Operator
            x = 3;
            y = 6;
            z = 0;
            a = 1;
            b = 24;

            //Addition, Subtraction, Multiplication, Division all work normally
            x = 6 + 4;

            //Pemdas using parenthesis works
            y = (a + b) / (z - x);

            //Eqaulity operators and Inequalities
            if (x == y)
            {
            }

            if (a < b)
            {
            }

            // There are two "conditional" operators as well that can 
            // be used to expand / enhance an evaluation...
            // ... and they can be combined together multiple times.

            // Conditional AND operator
            if ((x>y) && (a<b))
            {
            }

            // Conditional OR operator
            if ((x > y) || (a < b))
            {
            }

            //Also, there's an in-line conditional operator we
            // learned about in previous lesson... 
            string message = (x == 1) ? "Car" : "Boat";

            // Member access and Method invocation
            Console.WriteLine("Hi");
        }
    }
}
