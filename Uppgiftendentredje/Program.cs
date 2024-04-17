using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Uppgiftendentredje
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);



            Console.WriteLine();
            Console.WriteLine("your age is " + age);

            if (age < 0 || age > 101)
            {
                Console.WriteLine("du är fel");
            }
            else
            {
                if (age >= 18 && age <= 100)
                {
                    Console.WriteLine("Du får rösta");
                }
                else if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("du är minderårig.. loser");
                }
            }
            Console.ReadLine();
        }
    }
}

