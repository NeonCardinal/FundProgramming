using System;
using System.Collections.Generic;

namespace Library
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Library puLibrary = new Library();
            List<Book> books = new List<Book>();

            puLibrary.Books = books;

            for(int i = 0; i < 100; i++)
            {
                string name = "book" + i;
                string author = "test" + i;
                string izdatelstvo = "izdatelstvo" + i;
                int year = 2000 + i;
                string number = "SN000" + i;
                Book book = new Book(name, author, izdatelstvo, year, number);
                puLibrary.Books.Add(book);
            }


            for(int i = 0; i < puLibrary.Books.Count; i++)
            {
                puLibrary.PrintBooksInfo();
            }
        }
    }
}
