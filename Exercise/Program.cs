using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static List<Publication> list = new List<Publication>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Publication pub = new Publication();
            pub.setTitle("I love Programming");
            pub.setPrice(10.99);
            pub.setCopies(10);

            Book book = new Exercise.Book();
            book.Author = "Fred Carella";

            book.setTitle("I love linux");
            book.Title = "Joe's Awesome";
            book.setCopies(12);
            book.setPrice(100d);

            list.Add(pub);
            list.Add(book);

            foreach (Publication p in list) {
                Console.WriteLine(p);
            }



//            Console.WriteLine(pub);
//            Console.WriteLine(book);
        }
    }
}
