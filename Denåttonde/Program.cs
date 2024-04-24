using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denåttonde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            Console.WriteLine($"Arithmetic Operators");
            Console.WriteLine($" a + b is: {a + b}");
            Console.WriteLine($" c += 5 -> c is: {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($" a / b = {a / b}");
            Console.WriteLine($"a % b = {a % b}");


            Console.WriteLine($"Comparison operators");
            Console.WriteLine($" a == b is {a == b}");
            Console.WriteLine($" a != b is {a != b}");
            Console.WriteLine($" a > b is {a > b}");
            Console.WriteLine($" a < b is {a < b}");
            Console.WriteLine($" a >= b is {a >= b}");
            Console.WriteLine($" a <= b is {a <= b}");

            int c = 20;
            Console.WriteLine($"Assignment Operators");
            Console.WriteLine($" c += 5 -> c is: {c += 5}");
            Console.WriteLine($" c-= 5 -> c is: {c -= 5}");
            Console.WriteLine($" c *= 5 -> c is: {c *= 2}");
            Console.WriteLine($" c /= 5 -> c is: {c /= 4}");
            Console.WriteLine($" c %= 5 -> c is: {c %= 3}");

            int d = 10;
            Console.WriteLine($"Increament and Decrement operators");
            Console.WriteLine($"d++ is: {d++}");
            Console.WriteLine($"++d is: {++d}");
            Console.WriteLine($"d-- is: {d--}");
            Console.WriteLine($"--d is: {--d}");

            bool x = true;
            bool y = true;
            Console.WriteLine($"Logical Operators");
            Console.WriteLine($"x && y is {x && y}"); //AND
            Console.WriteLine($" x || y is {x || y}"); //OR
            Console.WriteLine($"!x is {!x}"); //NOT

            Console.ReadLine();
        }
        
    }
}
