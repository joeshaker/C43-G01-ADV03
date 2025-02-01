using AdvancedC_3.Classes;

namespace AdvancedC_3
{
    internal class Program
    {
        public delegate void BookProcess(List<Book> books, Func<Book, string> process);

        static void Main(string[] args)
        {
            #region Num1
            //BookDelegate<Book> bookDelegate;
            //bookDelegate = BookFunctions.GetTitle;
            //BookDelegate2 bookDelegate2;
            //bookDelegate2=BookFunctions.GetPrice;
            //List<Book> bookList = new List<Book>
            //{
            //    new Book("9781617294532", "C# in Depth", new string[] { "Jon Skeet" }, new DateTime(2019, 3, 23), 45.99m),
            //    new Book("9780132350884", "Clean Code", new string[] { "Robert C. Martin" }, new DateTime(2008, 8, 1), 38.50m),
            //    new Book("9780201633610", "Design Patterns", new string[] { "Erich Gamma", "Richard Helm", "Ralph Johnson", "John Vlissides" }, new DateTime(1994, 10, 21), 50.00m)
            //};
            //LibraryEngine.ProcessBook(bookList, bookDelegate);
            //LibraryEngine.ProcessBook(bookList, bookDelegate2);
            //LibraryEngine.ProcessBook(bookList, BookFunctions.GetPrice);
            //LibraryEngine.ProcessBook(bookList, BookFunctions.GetAuthors);

            #endregion
            #region Num2
            //List<Book> bookList = new List<Book>
            //{
            //    new Book("9781617294532", "C# in Depth", new string[] { "Jon Skeet" }, new DateTime(2019, 3, 23), 45.99m),
            //    new Book("9780132350884", "Clean Code", new string[] { "Robert C. Martin" }, new DateTime(2008, 8, 1), 38.50m),
            //    new Book("9780201633610", "Design Patterns", new string[] { "Erich Gamma", "Richard Helm", "Ralph Johnson", "John Vlissides" }, new DateTime(1994, 10, 21), 50.00m)
            //};
            //Func<Book, string> NewDelegate = BookFunctions.GetAuthors;
            //LibraryEngine.ProcessBook(bookList, NewDelegate);
            #endregion
            #region Num3
            //List<Book> bookList = new List<Book>
            //{
            //    new Book("9781617294532", "C# in Depth", new string[] { "Jon Skeet" }, new DateTime(2019, 3, 23), 45.99m),
            //    new Book("9780132350884", "Clean Code", new string[] { "Robert C. Martin" }, new DateTime(2008, 8, 1), 38.50m),
            //    new Book("9780201633610", "Design Patterns", new string[] { "Erich Gamma", "Richard Helm", "Ralph Johnson", "John Vlissides" }, new DateTime(1994, 10, 21), 50.00m)
            //};
            //Func<Book, string> GetISBN = delegate (Book b) { return $"ISBN : {b.ISBN}"; };
            //LibraryEngine.ProcessBook(bookList, GetISBN);
            #endregion
            #region Num4
            //List<Book> bookList = new List<Book>
            //{
            //    new Book("9781617294532", "C# in Depth", new string[] { "Jon Skeet" }, new DateTime(2019, 3, 23), 45.99m),
            //    new Book("9780132350884", "Clean Code", new string[] { "Robert C. Martin" }, new DateTime(2008, 8, 1), 38.50m),
            //    new Book("9780201633610", "Design Patterns", new string[] { "Erich Gamma", "Richard Helm", "Ralph Johnson", "John Vlissides" }, new DateTime(1994, 10, 21), 50.00m)
            //};
            //Func<Book, string> GetPublicationDate = (Book b) => b.PublicationTime.ToString();
            //LibraryEngine.ProcessBook(bookList, GetPublicationDate);
            //BookProcess bookProcess = LibraryEngine.ProcessBook;
            //bookProcess(bookList, GetPublicationDate);
            #endregion



        }
    }
}
