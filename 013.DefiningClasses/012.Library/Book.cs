using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        private string title;
        private string author;
        private string izdatelstvo;
        private int year;
        private string isbnNumber;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Izdatelstvo { get => izdatelstvo; set => izdatelstvo = value; }
        public int Year { get => year; set => year = value; }
        public string IsbnNumber { get => isbnNumber; set => isbnNumber = value; }

        public Book(string title, string author, string izdatelstvo, int year, string number)
        {
            this.title = title;
            this.author = author;
            this.izdatelstvo = izdatelstvo;
            this.year = year;
            this.isbnNumber = number;
        }
    }
}
