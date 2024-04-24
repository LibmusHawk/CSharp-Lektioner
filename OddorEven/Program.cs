using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddorEven2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listEven = new List<int>();
            List<int> listOdd = new List<int>();

            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    listEven.Add(i);
                    Console.WriteLine("even:" + i);
                }
                else if (i % 2 == 1)
                {
                    listOdd.Add(i);
                    Console.WriteLine("odd: " + i);
                }
            }

            Console.WriteLine("Antal even: ");
            Console.WriteLine(listEven.Count);

            Console.WriteLine("Antal odd: ");
            Console.WriteLine(listOdd.Count);

            Console.ReadLine();
        }
    }
}
