using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5);
            Console.WriteLine(result);
            PrintName();
            Console.ReadLine();
        }

        static void PrintName(string name = "Bob")
        {
            Console.WriteLine($" My name is {name}");
        }

        static int Add(int a, int b = default)
        {
            Console.WriteLine($"{a} {b}");
            return a + b;
        }
    }
}
