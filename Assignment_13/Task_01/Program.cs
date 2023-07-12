using Task_01;
try
{
    Book book = new Book(1, "Interesting Book", "Author");
    Library library = new Library(5);
    library.AddBook(book);
    Console.WriteLine(library.GetBook(0).Name);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch ( IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (BookNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Read books");
}