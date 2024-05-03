using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFieldsUpg
{
    internal class Program
    {

        class Product
        {
            public string name;
            public double price;
            public int stock;
            
            public Product(string name, double price, int stock)
                {
                this.name = name;
                this.price = price;
                this.stock = stock;
            }
        }
        static void Main(string[] args)
        {

            Product product = ReturnDetails();
            Console.WriteLine($"{product.name}\n{product.price}\n{product.stock}");
            Console.ReadLine();
        }

        static Product ReturnDetails()
        {
            Console.Write("Enter Product namn: ");
            string name = Console.ReadLine();

            Console.Write("Enter pris: ");
            double price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter stock: ");
            int stock = Convert.ToInt32(Console.ReadLine());

            return new Product(name, price, stock);
        }
    }
}
