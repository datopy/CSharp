// Exercise 4

Console.WriteLine("Input pyramid heigt:");
int height = int.Parse(Console.ReadLine());
int space = height - 1;
int asterix = 1;

for (int i = 1; i < height; i++)
{
    for (int k = 1; k <= space; k++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= asterix; j++)
    {
        Console.Write("*");
    }
    space--;
    asterix += 2;
    Console.WriteLine();
}
