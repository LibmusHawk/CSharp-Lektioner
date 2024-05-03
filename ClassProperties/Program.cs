using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties
{
    internal class Program
    {

        class Person
        {
            private string name;
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void SetName(string name)
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

            Console.ReadLine();
        }
    }
}
