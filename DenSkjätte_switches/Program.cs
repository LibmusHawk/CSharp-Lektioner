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

            Console.Write("Lista ut hurdan besvikelse du är: ");
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
                case 1: Console.WriteLine("Needs Improvement");
                    break;
                case 2: Console.WriteLine("ok");
                    break;
                case 3: Console.WriteLine("Satisfactory");
                    break;
                case 4: Console.WriteLine("Good");
                    break;
                case 5: Console.WriteLine("Excellent");
                    break;
                default: Console.WriteLine("Fail");
                    break;

                   

            }
            Console.ReadLine();

        }
    }
}
