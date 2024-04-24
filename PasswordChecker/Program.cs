using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ett lösenord: ");
            string password = Console.ReadLine();

            Console.Write("Konfirmera lösenorder: ");
            string passwordAgain = Console.ReadLine();

            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password))
            {

                Console.WriteLine("Enter validation");
            }
            else
            {
                if (password.Length >= 6 && passwordAgain.Length >= 6)
                {
                    Console.WriteLine("Long enough");
                    if (passwordAgain == password)
                    {
                        Console.WriteLine("Password Match");
                    }
                    else
                    {
                        Console.WriteLine("Passwords not Matching");
                    }
                }
                else
                {
                    Console.WriteLine("Enter Longer");
                }
            }

            Console.ReadLine();

        }
    }
}
