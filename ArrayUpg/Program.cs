using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayEXC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 6;

            int[] array = new int[length];

            for (int i = 1; i < length; i++)
            {
                array[i] = num * i;

                Console.Write(array[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
