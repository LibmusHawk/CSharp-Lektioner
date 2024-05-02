using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange bredden på triangeln: ");
            double bredden = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ange höjden på triangeln: ");
            double höjd = Convert.ToDouble(Console.ReadLine());

            double area = RäknaArea(bredden, höjd);
            Console.WriteLine($"Triangelns area är: {area}");
            Console.ReadLine();
        }
        static double RäknaArea(double bredden, double höjd)
        {
            return (bredden * höjd) / 2;
        }
    }
}
