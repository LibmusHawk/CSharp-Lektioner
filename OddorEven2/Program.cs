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
                    Console.WriteLine("EVEN:" + i);
                }
                else if (i % 2 == 1)
                {
                    listOdd.Add(i);
                    Console.WriteLine("ODD: " + i);
                }
            }

            Console.WriteLine("EVEN: ");
            Console.WriteLine(listEven.Count);

            Console.WriteLine("ODD: ");
            Console.WriteLine(listOdd.Count);

            Console.ReadLine();
        }
    }
}
