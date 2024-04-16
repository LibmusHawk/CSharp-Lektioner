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
            /*
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



                        for (int i = 0; i < loopCounter; i++)
                        {
                            Console.WriteLine("Bellend");
                        }

                        for (int i = 0; i < loopCounter; i++)
                        {
                            Console.WriteLine(i);
                        }
                        */

            Console.Write("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberAInput);

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.Write("Value of " + numberA + " x " + numberB + ": ");
            Console.WriteLine();


            do
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if(answer != actualAnswer)
                {
                    Console.WriteLine("close but wrong");
                    Console.WriteLine();
                }


            } while (answer != actualAnswer);
            Console.WriteLine("well done peasent");
           Console.ReadLine();
            
        }
    }
}
