using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

    }
    internal class Library
    {
        private Book[] _books;
        private int _counter;

        public Library(int libSize)
        {
            _books = new Book[libSize];
            _counter = 0;
        }

        public Book this[int i]
        {
            get { return _books[i];}
            set { _books[i] = value;}
        }

        public int BooksCount
        { 
            get { return _counter; } 
        }

        public void AddBook(Book book)
        {
            if (_counter > _books.Length)
            {
                Console.WriteLine("No more space in Library");
            }
            else
            {
                _books[_counter] = book;
                _counter++;
            }
        }

        public void RemoveBook(int index)
        {
            for (int i = index; i < _books.Length-1; i++)
            {
                _books[i] = _books[i + 1];
            }
            _counter--;
        }

        public int FindBook(string title)
        {
            int index = 0;

            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].Title == title)
                {
                    index = i;
                }
            }
            return index;
        }

    }
}
