using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 2;
            int num2 = 4;
            int num3 = 6;
            int num4 = 8;
            int num5 = 10;
            int num6 = 12;

            int sum = num1 + num2;
            Console.WriteLine("num1 + num2: " + sum);

            int product = num3 * num4;
            Console.WriteLine("num3 * num4: " + product);

            int remainder = num5 % num6;
            Console.WriteLine("num5 % num6: " + remainder);

            Console.WriteLine("Num6 (postfix increment): " + (num6++));
            Console.WriteLine("Num6 (prefix increment): " + (++num6));
            Console.WriteLine("Num6 (postfix decrement): " + (num6--));
            Console.WriteLine("Num6 (prefix decrement): " + (--num6));


            num5 += 5;
            Console.WriteLine("Num5 Addition: " + num5);

            num5 -= 3;
            Console.WriteLine("Num5 Subtraktion: " + num5);

            num5 *= 2;
            Console.WriteLine("Num5 Multiplikation: " + num5);

            num5 /= 4;
            Console.WriteLine("Num5 Division: " + num5);

            num5 %= 3;
            Console.WriteLine("Num5 Procent: " + num5);

            Console.ReadLine();
        }
    }
}
