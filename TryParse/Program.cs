using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgifter_29._4._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Voop";

            try
            {
                int num = Convert.ToInt32(text);
                Console.WriteLine($"Konvertering lyckades. Resultat: {num}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Konverteringsfel: {ex.Message}");
            }

            bool success;
            int result = ParseInt(text, out success);
            if (success)
            {
                Console.WriteLine($"Lyckades konvertera texten till ett heltal. Resultat: {result}");
            }
            else
            {
                Console.WriteLine("Misslyckades med att konvertera texten till ett heltal.");
            }
            Console.ReadLine();
        }

        static int ParseInt(string text, out bool success)
        {
            success = int.TryParse(text, out int result);
            return result;
        }
    }
}
