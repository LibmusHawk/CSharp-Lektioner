﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int num1 = random.Next(1,20);
            int num2 = random.Next(1, 20);
            int num3 = random.Next(1, 20);

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.ReadLine();

        }
    }
}
