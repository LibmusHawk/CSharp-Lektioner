using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleans10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isTrue = true;
            bool isFalse = false;

            Console.WriteLine($"isTrue: {isTrue}");
            Console.WriteLine($"isFalse: {isTrue}");

            Console.WriteLine($"Logical AND: {isTrue && isFalse}"); //FAlse
            Console.WriteLine($"Logical OR: {isTrue || isFalse}"); //True
            Console.WriteLine($"Logical NOT for True {!isTrue}"); //False
            Console.WriteLine($"Logical NOT for false: {!isFalse}"); //True


            int a = 20;
            int b = 10;
            Console.WriteLine($"a > b: {a > b}"); // True
            Console.WriteLine($"a < b: {a < b}"); // False
            Console.WriteLine($"a == b: {a == b}"); //False
            Console.WriteLine($"a != b: {a != b}");  //True

            //Boolean expression
            bool expression1 = (a > b) && isTrue;
            bool expression2 = (a < b) || isFalse;
            Console.WriteLine($"Expression 1: {expression1}");//True
            Console.WriteLine($"Expression 2: {expression2}");//False
            Console.ReadLine();
        }
    }
}
