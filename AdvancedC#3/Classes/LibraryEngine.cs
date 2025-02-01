using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_3.Classes
{
    public delegate string BookDelegate <T> (T b);
    public delegate string BookDelegate2(Book b);


    public class LibraryEngine
    {
        #region Num1
        //public static void ProcessBook(List<Book> bList, BookDelegate<Book> fptr)
        //{
        //    foreach (Book b in bList)
        //    {
        //        Console.WriteLine(fptr(b));

        //    }
        //}
        //public static void ProcessBook(List<Book> bList, BookDelegate2 fptr)
        //{
        //    foreach (Book b in bList)
        //    {
        //        Console.WriteLine(fptr(b));

        //    }
        //} 
        #endregion
        #region Num2
        //public static void ProcessBook(List<Book> bList, Func<Book, string> fptr)
        //{
        //    foreach (Book b in bList)
        //    {
        //        Console.WriteLine(fptr(b));

        //    }
        //} 
        #endregion
    }
}
