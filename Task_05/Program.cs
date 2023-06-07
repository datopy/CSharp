
// Exercise 5

Console.WriteLine("Min: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Max: ");
int max = int.Parse(Console.ReadLine());

Random random = new Random();
int pc_number = random.Next(min, max + 1);

while (true)
{
    Console.WriteLine("Guess the number");
    int user_number = int.Parse(Console.ReadLine());

    if (user_number != pc_number)
    {
        Console.WriteLine("Continue paying? (Y/N)");
        string confirm = Console.ReadLine().ToLower();
        if (confirm == "n")
        {
            break;
        }
    }
    else if (user_number == pc_number)
    {
        Console.WriteLine("You won, number was " + pc_number);
        break;
    }
    continue;
}