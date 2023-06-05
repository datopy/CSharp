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
