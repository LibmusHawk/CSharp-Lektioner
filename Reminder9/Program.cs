using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int divident = 10;
            int divisor = 3;

            int reminder = divident % divisor;

            Console.WriteLine($"Divident: {divident}");
            Console.WriteLine($"Divisor: {divisor}");
            Console.WriteLine($"Reminder: {reminder}");


            int num1 = 17;
            int num2 = 5;
            int reminder2 = num1 % num2;

            Console.WriteLine($"Divident: {num1}");
            Console.WriteLine($"Divisor: {num2}");
            Console.WriteLine($"Reminder2: {reminder2}");

            Console.ReadLine();

        }
    }
}
