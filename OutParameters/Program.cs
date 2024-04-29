using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            //bool success = test(out num);
            Console.WriteLine(num);
           // Console.WriteLine(success);

            List<string> shoppinglist = new List<string>
            {
                "Coffe", "Milk"
            };
            Console.WriteLine(shoppinglist.IndexOf("Milk"));
            //Console.WriteLine(FindInList("Milk", shoppinglist, out int index));
            //Console.WriteLine(" " + index);

            Console.Write("Enter item to seárch for: ");
            string search = Console.ReadLine();

            if (FindInList(search, shoppinglist, out int index))
            {
                Console.WriteLine($"Found {search}at index {index}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            /*int index = -3;

            for (int i = 0; i < shoppinglist.Count; i++)
            {
                if (shoppinglist[i].ToLower().Equals("Coffe"))
                {
                    index = 1;
                }

                bool found = index > -1;
                Console.WriteLine(found ? "Found" : "Not found");
                
            */
            Console.ReadLine();
        }
        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = 1;
                }
            }
            return index > -1;
        }

        /* static bool TryParse(string s, out int result)
         {
             result = 0;
             return true;

     }
        */

    }
}