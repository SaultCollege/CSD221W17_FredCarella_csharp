using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        private static List<SaleableItem> items = new List<SaleableItem>();

        static void Main(string[] args)
        {
            Book book = new Book();
            items.Add(book);
            Console.WriteLine(book);

        }
    }
}
