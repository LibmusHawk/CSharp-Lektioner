﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicError
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine();
            {
                if (age >= 18 && age <= 30)
                {
                    Console.WriteLine("Over 18");
                }
                else if (age >= 30 && age <= 50)
                {
                    Console.WriteLine("Over 30");
                }
                else if (age >= 50 && age <= 10000)
                {
                    Console.WriteLine("Over 50");
                }

                Console.ReadLine();
            }
        }
    }
}
