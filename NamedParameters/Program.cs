using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypeFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Steve";
            int age = 28;
            string address = "12th Blockstreet";

            PrintDetails(name, age, address);   

            Console.ReadLine();
        }

        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Adress: {address}");
        }
    }
}
