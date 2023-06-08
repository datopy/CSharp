
// Exercise 3 - Chinese Zodiac Signs

Console.WriteLine("Write your bith year:");
int birth_year = int.Parse(Console.ReadLine());
int mod = (birth_year - 2000) % 12;
string sign = "";

switch (mod)
{
    case 0:
        sign = "Dragon";
        break;
    case 1:
        sign = "Snake";
        break;
    case 2:
        sign = "Horse";
        break;
    case 3:
        sign = "Sheep";
        break;
    case 4:
        sign = "Monkey";
        break;
    case 5:
        sign = "Rooster";
        break;
    case 6:
        sign = "Dog";
        break;
    case 7:
        sign = "Pig";
        break;
    case 8:
        sign = "Rat";
        break;
    case 9:
        sign = "Ox";
        break;
    case 10:
        sign = "Tiger";
        break;
    case 11:
        sign = "Hare";
        break;
}

Console.WriteLine("Your sign is " + sign);