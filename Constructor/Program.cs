using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        /*
         struct Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }*/

        class Person
        {
            public string name;
            public int age;
            public Person(string name)
            {
                this.name = name;
                this.age = -1;
            }
            public Person(int age)
            {
                this.age = age;
                this.name = "";
            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.Write("Enter a age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(name, age);
            if (!string.IsNullOrEmpty(person.name))
            {
                Console.WriteLine(person.name);
            }
            if (person.age > -1) 
            {
                Console.WriteLine(person.age);
            }

            //Console.WriteLine(person.name);
            //Console.WriteLine(person.age);
            Console.ReadLine();
        }
    }
}
