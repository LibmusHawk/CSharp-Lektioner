using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddaellerjämnUpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Är den jämn?: ");
            int nummer = Convert.ToInt32(Console.ReadLine());
            nummer %= 2;

            if (nummer == 0) 
            {
                Console.WriteLine("Den är jämn");
            }
            else
            {
                Console.WriteLine("Den är inte jämn");
            }

            Console.ReadLine();
        }
    }
}
