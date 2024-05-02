using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Structures
{
    internal class Program
    {

        struct Person
        {
            public string name;
            public int age;
            public int Month;

            public Person(string name, int age, int Month)
            {
                this.name = name;
                this.age = age;
                this.Month = Month;
            }
        }
        static void Main(string[] args)
        {
            /*string name = "Bob";
            int age = 23;
            int Month = 5;

            Person person;


            person.name = "Bobby";
            person.age = 32;
            person.Month = 5;

            Console.WriteLine($"{name} - {age} - {Month}");
            Console.WriteLine($"{person.name} - {person.age} - {Month}");


            string newName = "";
            int newAge = 0;
            int newMonth = 0;
            ReturnPerson(ref newName, ref newAge, ref newMonth);
            Console.WriteLine($"{newAge} - {newName} - {newMonth}"); */

            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.Month}");
            Console.ReadLine();
        }


        static Person ReturnPerson()
        {
            Console.Write("Enter aname: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = Convert.ToInt32( Console.ReadLine());

            Console.Write("Enter month: ");
            int Month = Convert.ToInt32(Console.ReadLine());

            /*Person person;

            person.name = name;
            person.age = age;
            person.Month = Month;*/

            return new Person (name, age, Month);
        }

        /*static void ReturnPerson(ref string name, ref int age, ref int Month)
        {

            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter month: ");
            Month = Convert.ToInt32(Console.ReadLine());

            //return name;
           }*/
    }
}
