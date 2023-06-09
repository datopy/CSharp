
Console.WriteLine("Input array 1 length: ");
int len_1 = int.Parse(Console.ReadLine());
int[] nums_1 = new int[len_1];

Console.WriteLine($"Input {len_1} numbers: ");
for (int i = 0; i < len_1; i++)
{
    nums_1[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Input array 1 sort order (ASC/DESC): ");
string order_1 = Console.ReadLine();


Console.WriteLine("Input array 2 length: ");
int len_2 = int.Parse(Console.ReadLine());
int[] nums_2 = new int[len_2];

Console.WriteLine($"Input {len_2} numbers: ");
for (int i = 0; i < len_2; i++)
{
    nums_2[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Input array 2 sort order (ASC/DESC): ");
string order_2 = Console.ReadLine();

int index;

if (order_1.ToLower() == "asc")
{
    for (int i = 0; i < nums_1.Length - 1; i++)
    {
        for (int j = i + 1; j < nums_1.Length; j++)
        {
            if (nums_1[i] > nums_1[j])
            {
                index = nums_1[i];
                nums_1[i] = nums_1[j];
                nums_1[j] = index;
            }
        }
    }
}
else
{
    for (int i = 0; i < nums_1.Length - 1; i++)
    {
        for (int j = i + 1; j < nums_1.Length; j++)
        {
            if (nums_1[i] < nums_1[j])
            {
                index = nums_1[i];
                nums_1[i] = nums_1[j];
                nums_1[j] = index;
            }
        }
    }
}


if (order_2.ToLower() == "asc")
{
    for (int i = 0; i < nums_2.Length - 1; i++)
    {
        for (int j = i + 1; j < nums_2.Length; j++)
        {
            if (nums_2[i] > nums_2[j])
            {
                index = nums_2[i];
                nums_2[i] = nums_2[j];
                nums_2[j] = index;
            }
        }
    }
}
else
{
    for (int i = 0; i < nums_2.Length - 1; i++)
    {
        for (int j = i + 1; j < nums_2.Length; j++)
        {
            if (nums_2[i] < nums_2[j])
            {
                index = nums_2[i];
                nums_2[i] = nums_2[j];
                nums_2[j] = index;
            }
        }
    }
}

int[] merged = new int[len_1 + len_2];

for (int i = 0; i < nums_1.Length; i++)
{
    merged[i] = nums_1[i];
}


int starter = nums_1.Length;

for (int i = 0; i < nums_2.Length; i++)
{
    merged[starter] = nums_2[i];
    starter++;
}

Console.WriteLine();
foreach (int i in merged)
{
    Console.Write(i + " ");
}
Console.WriteLine();