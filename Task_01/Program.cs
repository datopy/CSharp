// Exercie 1

int count = 0;
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if (number % i == 0)
    {
        count++;
    }
}

if (count <= 2)
{
    Console.WriteLine("Prime Number");
}
else
{
    Console.WriteLine("Composite number");
}