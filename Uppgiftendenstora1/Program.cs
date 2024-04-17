using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgiftendenstora1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            const int LegalAge = 18;


            Console.WriteLine();

            if (age >= LegalAge)
            {
                Console.WriteLine("Du får rösta");
            }
            else
            {
                Console.WriteLine("du är minderårig.. loser");
            }


            int counter = 1;
            while (counter <= 5)
            {
                Console.WriteLine(counter);
                
                switch (counter)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;


                }
                counter++;
            }
            


            var name = "John";


            if (age >= LegalAge)
            Console.WriteLine("Välkommen " + name + " du är myndig med resultaten av " + counter);
            else
            {
                Console.WriteLine("Välkommen " + name + " du är inte myndig med resultaten av " + counter);
            }
            
            
            Console.ReadLine();
        }
    }
}
