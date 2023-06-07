// Exercise 2

int count = 0;
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if (number % i == 0)
    {
        count++;
    }
}

Console.WriteLine(count);