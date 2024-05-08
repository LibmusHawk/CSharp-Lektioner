using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YrkesprovUppgift1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //spara nummrorna/string
            var intNummer = 5;
            var doubleNummer = 10.5;
            var floatnummer = float.Parse("41.00027357629127", CultureInfo.InvariantCulture.NumberFormat);
            var stringTal = "Hello darkness smile friend";


            //Printa ut dem med convert
            Console.WriteLine(Convert.ToInt32(intNummer));
            Console.WriteLine(Convert.ToDouble(doubleNummer));
            Console.WriteLine(floatnummer);
            Console.WriteLine(Convert.ToString(stringTal));

            Console.ReadLine();
        }
    }
}
