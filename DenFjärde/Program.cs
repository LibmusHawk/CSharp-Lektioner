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

            var age = 23;
            Console.WriteLine(age);

            var negative = -55.2;
            Console.WriteLine(negative);

            var prec = 5.000002;
            Console.WriteLine(prec);

            var deci = 14.99M;
            Console.WriteLine(deci);

            var name = "den store";
            Console.WriteLine(name);

            var letter = 'b';
            Console.WriteLine(letter);
            Console.ReadLine();

        }

    }
}
