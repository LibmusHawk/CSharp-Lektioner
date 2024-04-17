using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgiftendenandra
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            string textAge = "532";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
