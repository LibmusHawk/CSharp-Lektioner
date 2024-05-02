using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassFields
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

           // public void SetName(string name)
            //{
                /* if (!string.IsNullOrEmpty(name))
                 {
                     this.name = name;
                 }
                 else
                 {
                     this.name = "invalid";
                 }*/
           //     this.name = !string.IsNullOrEmpty(name) ? name : "Invalid";
          //  }

           // public string GetName()
        //    {
        //        return name;
        //    }

       //     public void SetAge(int age)
         //   {
                /* if (age >= 0 && age <= 100)
                 {
                     this.age = age;
                 }
                 else
                 {
                     this.age = -1;
                 }*/
     //           this.age = age >= 0 && age <= 150 ? age : -1;
       //     }

            //public int GetAge()
            // {
            //     return age;
            // }

        //    public int GetAge() => age;

       //     public string ReturnDetails()
         //   {
        //        return $"Name: {name}\nage: {age}";
      //      }

            public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid";
            public string GetName() => name;
            public void SetAge(int age) => this.age = age >= 0 && age <= 150 ? age : -1;
            public int GetAge() => age;
            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }
        

            static void Main(string[] args)
            {

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Person person = new Person("Testo", 37);
                Console.WriteLine(person.ReturnDetails());

                //person.name = "Harry";
                //person.age = 25;
                person.SetName("");
                person.SetAge(-2);
                Console.WriteLine(person.ReturnDetails());

                Console.WriteLine($"your name is {person.name} and your age is {person.age}");

                Console.ReadLine();
            }
        }
    }
}
