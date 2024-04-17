using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgiftendenfjärde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name; ");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Nämen goddag " + name);

            Console.ReadLine();
        }
        
    }
}
