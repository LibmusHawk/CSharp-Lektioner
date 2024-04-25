using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidFunction
{

    class test
    {
        public static void something()
        {
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            test.something();

            welcomemessage();

            Console.ReadLine();
        }
        static void welcomemessage()
        {
            Console.WriteLine("welcome to this shitshow");
        }

    }
}