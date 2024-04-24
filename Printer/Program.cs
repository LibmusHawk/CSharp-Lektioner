using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prtinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter: 'C# is fun, Im gonna code C# tomorrow' in the console: ");
            string message = Console.ReadLine();

            char[] chars = message.ToCharArray();
            Array.Reverse(chars);

            if (message == null)
            {
                Console.WriteLine("Invalid message");
            }
            else
            {
                Console.WriteLine(message); // ordning

                Console.WriteLine(chars);

                for (int i = 0; i < message.Length; i++)
                {
                    Console.WriteLine(message[i]); // Uppifrån ner :)
                }

                for (int i = 0; i < chars.Length; i++)
                {
                    Console.WriteLine(chars[i]); // Uppifrån ner :)
                }
            }

            Console.ReadLine();
        }
    }
}
