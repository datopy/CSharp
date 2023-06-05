
// Exercise 1 - Weather

Console.WriteLine("What temperatue is now?");

int i_degree = int.Parse(Console.ReadLine());

if (i_degree < 0)
{
    Console.WriteLine("Freezing");
}
else if (i_degree < 30)
{
    Console.WriteLine("Good Weather");
}
else
{
    Console.WriteLine("Hot");
}

// Exercise 2 - Rock, Paper, Scissors

Random rnd = new Random();
string[] words = new string[] { "rock", "paper", "scissors" };

bool user_win = false;

while (!user_win)
{
    string pc_word = words[rnd.Next(0, words.Length)];

    Console.WriteLine("Rock, Paper, Scissors...");

    string user_word = Console.ReadLine().ToLower();

    if (pc_word == user_word)
    {
        user_win = true;
        Console.WriteLine("User Won");
    }
    else
    {   
        user_win = false;
        Console.WriteLine("It was " + pc_word + ", Try Again");
    }
}



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

