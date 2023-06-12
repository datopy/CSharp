
SumArrayNumber(new int[] { 1, 2, 1234, 4, 5 }, 2);

void SumArrayNumber(int[] numbers, int index)
{
    int sum = 0;
    string myNumber = numbers[index].ToString();
    Console.WriteLine(myNumber);

    for (int i = 0; i < myNumber.Length; i++)
    {
        int a = myNumber[i] - '0';
        sum += a;
    }
    Console.WriteLine(sum);
}