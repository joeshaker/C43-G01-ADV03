using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_3.Classes
{
    public class Book
    {
        public Book(string iSBN, string title, string[] author, DateTime publicationTime, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
            PublicationTime = publicationTime;
            Price = price;
        }

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string [] Author { get; set; }
        public DateTime PublicationTime { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"The book ISBN:{ISBN} and Title is {Title} By Authors {Author} and PublicationTime:{PublicationTime} " +
                $"and its price {Price}";
        }

    }
}
