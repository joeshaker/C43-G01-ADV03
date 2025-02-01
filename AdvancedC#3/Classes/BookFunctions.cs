using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_3.Classes
{
    public class BookFunctions
    {
        public static string GetTitle(Book b)
        {
            return "Title "+b.Title;
        }
        public static string GetAuthors(Book b)
        {
            return string.Join(", ", b.Author);

        }
        public static string GetPrice(Book b)
        {
            return $"Price = {b.Price}";
        }
    }
}
