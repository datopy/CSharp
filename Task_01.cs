// Exercise 1 - Weather

Console.WriteLine("What temperatue is now?");

int i_degree = int.Parse(Console.ReadLine());

if (i_degree < 0)
{
    Console.WriteLine("Freezing");
}
else if (i_degree < 30)
{
    Console.WriteLine("Good Weather");
}
else
{
    Console.WriteLine("Hot");
}