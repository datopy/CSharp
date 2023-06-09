

Console.WriteLine("Array Length: ");
int len = int.Parse(Console.ReadLine());

string[] strings = new string[len];
Console.WriteLine("Input Strings: ");

for (int i = 0; i < len; i++)
{
    strings[i] = Console.ReadLine();
}

int[] numbers = new int[len];
Console.WriteLine("Input numbers: ");

for (int i = 0; i < len; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

string[] merged  = new string[len];

for (int i = 0; i < len; i++)
{
    merged[i] = strings[i] + " " + numbers[i];
}

foreach (string s in merged)
{
    Console.WriteLine(s);
}