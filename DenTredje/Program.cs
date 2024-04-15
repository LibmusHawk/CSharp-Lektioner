using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DetTredje
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Magenta;
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

            string textAge = "23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textHugeNumber = "90000000";
            long HugeNumber = Convert.ToInt64(textHugeNumber);
            Console.WriteLine(HugeNumber);

            string textNegativ = "-55.2";
            double negativ = Convert.ToDouble(textNegativ, CultureInfo.InvariantCulture);
            Console.WriteLine(negativ);

            string textPrec = "5.000021";
            float prec = Convert.ToSingle(textPrec, CultureInfo.InvariantCulture);
            Console.WriteLine(prec);

            string textDeci = "14.99";
            decimal deci = Convert.ToDecimal(textDeci, CultureInfo.InvariantCulture);
            Console.WriteLine(deci);

            Console.ReadLine();

        }

    }
}
