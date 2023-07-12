using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Library
    {
        private Book[] _books;
        public int Capacity { get; set; }
        private int _counter;

        public Library(int libSize)
        {
            Capacity = libSize;
            _books = new Book[Capacity];
            _counter = 0;
        }

        public void AddBook(Book book)
        {
            if  (book == null)
                throw new ArgumentNullException("You should add book");
            if (_counter >= _books.Length)
            {
                throw new IndexOutOfRangeException("No more space n library");
            }
            else
            {
                _books[_counter] = book;
                _counter++;
            }
        }

        public Book GetBook(int id)
        {
            if (_books[id].Name == "" || _books[id].Name == null)
            {
                throw new BookNotFoundException("Book is not in library");
            }
            return _books[id];
        }
    }
}
