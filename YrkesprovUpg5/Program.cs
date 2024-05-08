using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YrkesprovUpg5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            // Sätter in Dictionary orden
            Dictionary<string, string> teacher = new Dictionary<string, string>
            {
                {"Bok", "en bok är papper!" },
                {"Mat", "Man får energi och dör inte!" },
                {"Gym", "En plats och hånglas" },
                {"Antons klassrum", "En plats och gå sönder" }
            };

            //Det som får det och alltid starta
            while (running)
            {
               //början på programmet
                Console.WriteLine("1. Lagra till ord");
                Console.WriteLine("2. Kolla upp definitionen");
                Console.WriteLine("3. Visa alla ord + definition");
                Console.WriteLine("4. Exit");
                Console.WriteLine("");

                Console.Write("Välj mellan 1-4: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                //Case 1, skriver in nya ord
                switch (choice)
                {
                    case 1:
                        Console.Write("Chose 1 Lagra till ord: ");
                        string newSubj = Console.ReadLine();

                        Console.Write("Skriv in beskrivning: ");
                        string newTeach = Console.ReadLine();

                        if (newSubj == "" || newTeach == "")
                        {
                            Console.WriteLine("ERROR no subject or teacher added!");
                        }
                        else
                        {
                            teacher[newSubj] = newTeach;
                            Console.WriteLine("Nytt ord ");
                        }

                        break;

                        //case 2, söker ut efter existerande ord
                    case 2:
                        Console.Write("Chose 2, Write the name of the subject you want to remove: ");
                        string subjRemove = Console.ReadLine();
                       

                        if (subjRemove == "" || string.IsNullOrEmpty(subjRemove))
                        {
                            Console.WriteLine("ERROR invalid subject");
                        }
                        else
                        {
                            if (teacher.ContainsKey(subjRemove))
                            {
                                Console.WriteLine("");
                                Console.WriteLine($"Found {subjRemove} with the description ");
                                Console.WriteLine("");
                                foreach (var item in teacher)
                                {
                                    Console.WriteLine(item.Key + " - " + item.Value);
                                }
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"{subjRemove} does not exist");
                            }
                        }
                        break;

                        //Case 3, visar alla ord sparade inne i dictionaryn
                    case 3:
                        Console.WriteLine("Chose 3, Visar alla sparade ord/beskrivningar");

                        foreach (var item in teacher)
                        {
                            Console.WriteLine(item.Key + " - " + item.Value);
                        }
                        Console.WriteLine("");
                        break;

                        //Case 4, stoppar programmet
                    case 4:
                        Console.WriteLine("Chose 4, Stopped, press enter");
                        running = false;
                        break;
                }
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
