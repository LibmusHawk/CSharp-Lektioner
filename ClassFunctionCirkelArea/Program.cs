using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassFunctionCirkelArea
{
    internal class Program
    {

        class Circle
        {
            public double Radius { get; set; }


             public Circle(double radius)
            {
                this.Radius = radius;
            }

            public double calculatearea()
            {
                return Math.PI * Radius * Radius;
            }
        }
        static void Main(string[] args)
        {
            Circle circle = new Circle(1.5);
            Console.WriteLine(circle.calculatearea());
            Console.ReadLine();
           
        }
    }
}
