using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassToString
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

            /*public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }*/

            public override string ToString()
            {
                return $"Name: {Name}\tAge: {age}";
            }

            public override bool Equals(object obj) 
            {
                if (obj is Person)
                {
                    Person person = obj as Person;
                    return name.Equals(person.name) && age == person.age;
                }
                return false;
                
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Bob", 34);
            Person test = new Person("Bob", 34);
            //Console.WriteLine(person);

            if (person.Equals(person)) 
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("Not same");
            }

            //int age = 23;
            //Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
