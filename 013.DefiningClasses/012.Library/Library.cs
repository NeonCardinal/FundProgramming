using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Library
    {
        private string name;
        private List<Book> books;

        public string Name { get => name; set => name = value; }
        public List<Book> Books { get => books; set => books = value; }

        public Library()
        {
            this.name = null;
            this.books = null;
        }

        public Library(string name, List<Book> books)
        {
            this.name = name;
            this.books = books;
        }

        public void AddBook(Book book)
        {
            this.books.Add(book);
        }

        public Book BookSearch(Book book, string author)
        {
            Book result;

            result = books.Find(x => x.Author == author);

            return result;
        }
        
        public void PrintInfoBook(Book book)
        {
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);
            Console.WriteLine(book.Year);
            Console.WriteLine(book.IsbnNumber);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
    }
}
