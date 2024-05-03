using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get => name;
                set => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid Name!";
            }

            public int Age
            {
                get => age;
                set => age = value;
            }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;

                Name = name;
                Age = age;
            }

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Bob", 34);
            Console.WriteLine(person.ReturnDetails());
            Console.WriteLine(person.ToString());
            Console.WriteLine(person);

            int age = 23;
            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
