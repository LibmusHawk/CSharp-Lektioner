using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace voidFunctions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message();
            CreateAndPointArray();
            Console.ReadLine();
        }

        static void CreateAndPointArray()
        {
            int[] numbers = new int[5] {0, 1, 2, 3, 4};

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item} ");
            }
        }

        static void Message()
        {
            Console.WriteLine("Count from 0 to 4!");
        }
    }
}
