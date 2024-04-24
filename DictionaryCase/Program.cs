using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            Dictionary<string, string> teacher = new Dictionary<string, string>
            {
                {"MO", "Waltonen" },
                {"MA", "Peter" },
                {"GY", "Otto" },
                {"Kivi", "Galpador" }
            };

            while (running)
            {
                Console.WriteLine();

                Console.Write("Choose between 1-4: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Chose 1 Enter new subject: ");
                        string newSubj = Console.ReadLine();

                        Console.Write("Enter Teacher: ");
                        string newTeach = Console.ReadLine();

                        if (newSubj == "" || newTeach == "")
                        {
                            Console.WriteLine("ERROR no subject or teacher added!");
                        }
                        else
                        {
                            teacher[newSubj] = newTeach;
                            Console.WriteLine("New teacher was added");
                        }

                        break;
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
                                teacher.Remove(subjRemove);
                                Console.WriteLine($"Removed {subjRemove}");
                            }
                            else
                            {
                                Console.WriteLine($"{subjRemove} does not exist");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Chose 3, showing subjects and their teachers");

                        foreach (var item in teacher)
                        {
                            Console.WriteLine(item.Key + " - " + item.Value);
                        }
                        break;
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
