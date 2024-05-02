using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool looping = true;
            while (looping)
            {
                // int num = 0;
                try
                {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(num);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Only numbers less that 2 billion");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Numbers the numbers mason");
                }
                catch (Exception)
                {
                    Console.WriteLine("something has went wrong!");
                }
            }
            //Console.WriteLine(num);

            Console.WriteLine("Bye bye...");
            /*try
            {

            }catch (Exception)
            {
                throw;
            
            }
            */
            Console.ReadLine();
        }
    }
}
