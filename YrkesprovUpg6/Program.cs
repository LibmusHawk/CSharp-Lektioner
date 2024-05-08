using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YrkesprovUpg6
{
    internal class Program
    {
        //klassen book och alla dess info inne
        class Book
        {
            public string Title;
            public string Author;
            public int PublicationYear;

            public Book(string title, string author, int publicationYear)
            {
                this.Title = title;
                this.Author = author;
                this.PublicationYear = publicationYear;

            }
        }

        // Book book returndetails från den nedre blocket och skrivs ut till konsolen
        static void Main(string[] args)
        {

            Book book = ReturnDetails();
            Console.WriteLine($"Title: {book.Title}\nAuthor: {book.Author}\nPublication Year: {book.PublicationYear}");
            Console.ReadLine();
        }
        //Nedre blocket med infon sparad
        static Book ReturnDetails()
        {
            string title = "Eragon";
            string author = "Christopher Paolini";
            int publicationYear = Convert.ToInt32(2002);
            

            return new Book(title, author, publicationYear);
        }
    }
}
