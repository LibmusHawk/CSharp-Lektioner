using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFunctions
{
    internal class Program
    {

        class Person
        {
            public string name;
            public int age;
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void SetName(string name)
            {
                this.name = name;
            }

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Testo", 37);
            //Console.WriteLine($"Name: {person.name} \nAge {person.age}");
            Console.WriteLine(ReturnDetails(person));

            //person.name = "Harry";
            //person.age = 25;
            person.SetName("Harry");
            Console.WriteLine(person.ReturnDetails());

            Console.ReadLine();
        }

        static string ReturnDetails(Person person)
        {
            return $"Name: {person.name}\nAge: {person.age}";
        }
        /*static string ReturnDetails(string name, int age)
        {
            return $"Name: {name}\nAge: {age}";
        }*/
    }
}
