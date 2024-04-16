using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenSkjätte
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();

            Console.Write("Enter a day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());
            /*
            if (day == 1)
            {
                Console.WriteLine("det läskiga dagen");
            }
            else if(day == 2)
            {
                Console.WriteLine("Den andra läskiga dagen");
            }
            */
            switch (day)
            {
                case 1: Console.WriteLine("Mon");
                    break;
                case 2: Console.WriteLine("Tue");
                    break;
                case 3: Console.WriteLine("Wedding");
                    break;
                case 4: Console.WriteLine("Thu");
                    break;
                case 5: Console.WriteLine("Fri");
                    break;
                case 6: Console.WriteLine("sat");
                    break;
                case 7: Console.WriteLine("Sun");
                    break;
                default: Console.WriteLine("Invalid");
                    break;

                   

            }
            Console.ReadLine();

        }
    }
}
