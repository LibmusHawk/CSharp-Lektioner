using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looptylopp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();

            Console.Write("How many times you want the loopity loop?: ");
                int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("Sorry bellend, the numbers");
            }
            else
            {
                for(int i = 0; i < loopCounter; i++) 
                {
                    Console.WriteLine("Bellend");
                }
            }



            /*for (int i = 0; i < loopCounter; i++)
            {
                Console.WriteLine("Bellend");
            }

            for (int i = 0; i < loopCounter; i++)
            {
                Console.WriteLine(i);
            }
            */

            Console.ReadLine();
        }
    }
}
