﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
                { 1, 2, 3, 4, 5, 6, 7, 8, 9,};

            Array.Clear(numbers, 5, 5);

            for (int i = 5; i < 10; i++)
            {
                numbers[i] = default;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item}");
            }

            Console.ReadLine();
        }
    }
}
