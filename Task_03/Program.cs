
//Exercise 3


double sum = 0;
int nums_length = 0;

string[] numbers = Console.ReadLine().Split();

foreach (string number in numbers)
{
    double d_number = double.Parse(number);
    if (d_number > 0)
    {
        sum += d_number;
        nums_length++;
    }
}

double avg = sum / nums_length;

Console.WriteLine("Sum of positive numbers " + sum + "\n" +
                  "Avg of positive numbers " + avg);
