using LibrarySystem;

Book book1 = new Book("A", "A", 1);
Book book2 = new Book("B", "B", 2);
Book book3 = new Book("C", "C", 3);

Library library = new Library(3);

library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(library[i].Title);
}

Console.WriteLine(library.BooksCount);
library.RemoveBook(2);
Console.WriteLine(library.BooksCount);

for (int i = 0; i < 2; i++)
{
    Console.WriteLine(library[i].Title);
}

Console.WriteLine(library.FindBook("B"));

