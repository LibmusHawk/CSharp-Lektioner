using System;
using System.Runtime.InteropServices;

namespace Uppgift_5
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //Insatta arrays
            int[] numbersReverse = { 10 , 2 , 37 , 400 , 59 , 1387};
            int[] numbers2 = { 10, 2, 37, 400, 59, 1387 };
            //Array reverse
            Array.Reverse(numbersReverse);

            //2 stycke Array loops
            for (int i = 0; i < numbersReverse.Length; i++) 
            {
                Console.Write(numbersReverse[i]);
            }
            Console.WriteLine("");
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.Write(numbers2[i]);
            }
            Console.ReadLine();
        }
    }
}
