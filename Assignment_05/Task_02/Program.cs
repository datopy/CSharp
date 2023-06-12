
PrinResult();


char[] FillArray()
{
    Console.WriteLine("Enter Array Size: ");
    int size = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter Array Members: ");
    char[] chars = new char[size];

    for (int i = 0; i < size; i++)
    {
        chars[i] = char.Parse(Console.ReadLine());
    }

    return chars;
}

int CountChar(char[] chars, char symbol)
{
    int count = 0;
    foreach (char c in chars)
    {
        if (c == symbol) count++;
    }

    return count;
}

void PrinResult()
{
    char[] chars = FillArray();

    Console.WriteLine("Choose symbol to count: ");
    char symbol = char.Parse(Console.ReadLine());

    int charCount = CountChar(chars, symbol);

    Console.WriteLine($"Symbol '{symbol}' found {charCount} time(s)");
}







