using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YrkesprovUpg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enter number input
            Console.Write("Enter Number: ");
            string numberInput = Console.ReadLine();
            int number = Convert.ToInt32(numberInput);

            Console.WriteLine();

            //if else statement om nummret är positivt/negativt
            {
                if (number >= 1 && number <= 1000000000)
                {
                    Console.WriteLine("Siffran är positiv");
                }
                else if (number >= 0)
                {
                    Console.WriteLine("Siffran är noll");
                }
                else
                {
                    Console.WriteLine("Siffran är negativ");
                }

                Console.ReadLine();
            }
        }
    }
}

