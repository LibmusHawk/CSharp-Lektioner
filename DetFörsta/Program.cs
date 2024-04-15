using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DetFörsta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            Console.WriteLine("This is a test");
            //system.Console.WriteLine("C#2");

            //Option 1

            //int x = 10;
            //int y = 20;
            //int z = 30;

            //Option 2


            int x = 10;
            int y = 20;
            int z = 30;

            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long hugNumber = 9048;
            Console.WriteLine(hugNumber);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            double negativ = -55.2D;
            Console.WriteLine(negativ);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float prec = 5.0000021F;
            Console.WriteLine(prec);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal deci = 14.99M;
            Console.WriteLine(deci);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            Console.ReadLine();

        }

    }
}
