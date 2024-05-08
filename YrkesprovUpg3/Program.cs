using System;
namespace YrkesprovUpg3

{
    class Program

    {

        static void Main(string[] args)

        {

            string Hej = "Hej ";
            String[] Names = new string[3];

           //array sorting
            Names[0] = "Tesla";
            Names[1] = "Mustang";
            Names[2] = "Corvette";


            // Loop
            for (int i = 0; i < Names.Length; i++)

            {

                Console.WriteLine(Hej + Names[i]);
            }



            Console.ReadKey();

        }

    }

}
