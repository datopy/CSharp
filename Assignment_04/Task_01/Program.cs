
Console.WriteLine("Array length: ");
int[] numbers = new int[int.Parse(Console.ReadLine())];
Console.WriteLine("Input Numbers: ");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Unsorted List: ");
foreach (int i in numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();
int index;

for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] > numbers[j])
        {
            index = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = index;
            Console.WriteLine();

            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
        }
    }
}

Console.WriteLine("\n");
Console.WriteLine("Sorted List: ");

foreach (int i in numbers)
{
    Console.Write(i + " ");
}