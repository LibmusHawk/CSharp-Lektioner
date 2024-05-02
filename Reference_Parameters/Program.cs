using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int num = 10;
            string name = "Stacy";
            num = Assign(ref num, ref name);
            Console.WriteLine(num);
            */
            int.TryParse("", out int index);
            string name = "Stacy";

            Console.Write("Enter your new name:");
            string newName = Console.ReadLine();
            
            
            if (ChangeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is: {name}");
            }
            else 
            {
                Console.WriteLine("It can't be null.. peasant");
            }
            Console.ReadLine();
        }
        static bool ChangeName (ref string name, string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
           return false;
        }
        static void Assign(ref int num, ref string name)
        {
            name = "Steve";
            num = 20;
        }
    }
}
