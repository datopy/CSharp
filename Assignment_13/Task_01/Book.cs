using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Book
    {
        private int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public Book(int id, string name, string author)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException("Null Id");
            }
            if (name == null)
            {
                throw new ArgumentNullException("Null Name");
            }
            if (author == null)
            {
                throw new ArgumentNullException("Null Author");
            }
                
            BookId = id;
            Name = name;
            Author = author;            
        }
    }
}
