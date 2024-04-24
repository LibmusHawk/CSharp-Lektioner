using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int num3 = 20;

            int[] numbers = new int[3];

            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 20;

            //Console.Write("Enter a number: ");
            //numbers[0] = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a second number: ");
            //numbers[1] = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a third number: ");
            //numbers[2] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{num1} {num2} {num3}");
            //Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

            //EXAMPLE 2

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter number {i + 1}: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"{numbers[i]}");
            //}

            //foreach (int num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}

            // EXAMPLE 3

            const int angleCount = 3;
            int[] angles = new int[angleCount];

            for (int i = 0; i < angles.Length; i++)
            {
                Console.Write($"Enter a angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;

            foreach (int angle in angles)
            {
                angleSum += angle;
            }

            Console.WriteLine(angleSum);
            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");

            Console.ReadLine();
        }
    }
}
