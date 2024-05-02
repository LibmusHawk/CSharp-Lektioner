using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5 };

            int sum = SumOfNumbers(numbers);

            Console.WriteLine($"Summan av alla tal är: {sum}");

            Console.WriteLine($"Arrayens längd är: {numbers.Length}");

            if (sum > -1)
            {
                Console.WriteLine($"Totalen är: {sum}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }

            if (OmNegativ(numbers))
            {
                Console.WriteLine("Cannot add up an empty array");
            }
            else
            {
                Console.WriteLine("Arrayen innehåller inga negativa värden.");
            }
            Console.ReadLine();
        }

        static int SumOfNumbers(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        static bool OmNegativ(int[] array)
        {
            foreach (int num in array)
            {
                if (num < 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
