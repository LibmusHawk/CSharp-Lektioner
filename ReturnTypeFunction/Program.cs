using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypeFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ReturnNameAgePair();
            PrintIntroduction();

            int[] numbers = new int[3];

            /*Console.Write{"Enter number: "};
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write{"Enter number: "};
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write{"Enter number: "};
            numbers[2] = Convert.ToInt32(Console.ReadLine());
            */

            for (int i = 0; i < numbers.Length; i++)
                {
                //Console.Write("Enter a number: ");
                //numbers[i] = Convert.ToInt32(Console.ReadLine());
                numbers[i] = ReadNumberFromConsole();
            }

            int[] newNumbers = CreateRandomArray();

            foreach (var item in  newNumbers)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine(Add());
            Console.ReadLine();
        }

        static void something()
        {

        }
        static void conversion()
        { }

        static void calculation()
        {
            
        }

        static int Add()
        {
            return 5 + 5;
        }
        static int[] CreateRandomArray()
        {
            return new int[3] {0,1,2};
        }

        static int ReadNumberFromConsole()
        {
            Console.Write("Enter number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string ReturnName()
        {
            return "Bob";
        }

        static int ReturnAge()
        {
            return 37;
        }

        static string ReturnNameAgePair()
        {
            return $"{ReturnName()} - {ReturnAge()}";
        }
            static void PrintIntroduction()
        {
            Console.WriteLine("Welcome to code c#");

            string name = ReturnName();
            int age = ReturnAge();
            string output = $"Hi my name is {name} and my age is {age}";
            Console.WriteLine(output);
        }
    }
}
