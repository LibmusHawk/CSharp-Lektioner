using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary<int, string> names = new Dictionary<int, string>
            {
                {1, "bob" },
                { 2, "blobban" },
                { 3, "blob" }
            };

            for (int i = 0; i < names.Count; i++) 
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
            Console.WriteLine();

            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine($"{item.Key} {item.Value}");

                Console.ReadLine();*/


            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                { "PU", "bob" },
                { "PU2", "blobban" },
                { "Svenska", "blob" }
            };
            
            if (teachers.TryGetValue("Svenska", out string teacher))
            {
                Console.WriteLine(teacher);

                teachers["Math"] = "Bob";
            }
            else
            {
                 Console.WriteLine("PU teacher not found");
            }

            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Teacher not found");
            }

            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.ReadLine();
        }
    }
}
