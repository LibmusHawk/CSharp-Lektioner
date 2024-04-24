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
           

            int num1 = 2;
            int num2 = 3;
            int num3 = 4;
            int num4 = 2;


           

            Console.WriteLine($"Logical AND: {num1 > num3 && num2 < num4}");
            Console.WriteLine($"Logical OR: {num1 < num3 || num2 > num4}"); //True
            Console.WriteLine($"Logical NOT {!isTrue}"); //False


            int a = 20;
            int b = 10;
            Console.WriteLine($"a > b: {num1 > num3}"); // True
            Console.WriteLine($"a < b: {num2 < num4}"); // False
            Console.WriteLine($"a == b: {num1 == num4}"); //False
            Console.WriteLine($"a != b: {num2 != num3}");  //True

            //Boolean expression
            bool expression1 = (num1 > num3) && (num2 < num4);
            bool expression2 = (num1 < num3) || (num2 > num4);
            Console.WriteLine($"Expression 1: {expression1}");//True
            Console.WriteLine($"Expression 2: {expression2}");//False
            Console.ReadLine();
        }
    }
}
