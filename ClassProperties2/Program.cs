using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties2
{
    internal class Program
    {

        class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;

                Name = name;
                Age = age;
            }

          /*  public void SetName(string name)
            {
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid";
            }

            public string GetName()
            {
                return name;
            }

            public void SetAge(int age)
            {
                this.age = age >= 0 && age <= 150 ? age : -1;
            }

            public int GetAge()
            {
                return age;
            } */

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }
        } 


        static void Main(string[] args)
        {
            Person person = new Person("Bob", 34);
            Console.WriteLine(person.ReturnDetails());

            person.Name = "Larry";

            Console.WriteLine(person.ReturnDetails());

            Console.WriteLine($"Your name is {person.Name} and your age is {person.Age}");

            Console.ReadLine();
        }
    }
}
