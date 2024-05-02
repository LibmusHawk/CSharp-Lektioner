using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Please enter only numbers! {e.Message}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Please enter a value under billions thank you very much, {e.Message}");
            }

            catch (Exception e) 
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            Console.WriteLine("Bye bye..");
            Console.ReadLine();
        }
    }
}
