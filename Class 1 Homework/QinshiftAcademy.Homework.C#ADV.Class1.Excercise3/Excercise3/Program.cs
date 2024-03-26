Dictionary<int, string> choiceMap = new Dictionary<int, string>()
{
    { 1, "Rock" },
    { 2, "Paper" },
    { 3, "Scissors" }
};

int userScore = 0;
int computerScore = 0;

while (true)
{
    Console.WriteLine("Let's play Rock, Paper, or Scissors");
    Console.WriteLine("Pick 1) Rock");
    Console.WriteLine("Pick 2) Paper");
    Console.WriteLine("Pick 3) Scissors");
    string pickNumberString = Console.ReadLine();
    bool parsedNumber = int.TryParse(pickNumberString, out int pickNumber);

    if (!parsedNumber || pickNumber < 1 || pickNumber > 3)
    {
        Console.WriteLine("Invalid input. Please input numbers from 1 to 3");
    }
    else
    {
        Random rnd = new Random();
        int randomValue = rnd.Next(1, 4);

        Console.WriteLine($"You chose {choiceMap[pickNumber]} and the computer chose {choiceMap[randomValue]}");

        if (pickNumber == randomValue)
        {
            Console.WriteLine("It's a draw! Play again.");
        }
        else if ((pickNumber == 1 && randomValue == 3) || (pickNumber == 2 && randomValue == 1) || (pickNumber == 3 && randomValue == 2))
        {
            Console.WriteLine("You win!");
            userScore++;
        }
        else
        {
            Console.WriteLine("Computer wins!");
            computerScore++;
        }

        Console.WriteLine($"Score: User {userScore} - Computer {computerScore}");
   
        if (userScore != 0)
        {
            double userPercentage = ((double)userScore / (userScore + computerScore)) * 100;
            Console.WriteLine($"Your win percentage is {userPercentage}%");
        }
        else
        {
            Console.WriteLine("Your win percentage is 0%");
        }
    }

    Console.WriteLine("Do you want to play again? (Press Enter to play again, or any other button to exit)");
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

    if (keyInfo.Key != ConsoleKey.Enter)
    {
        break;
    }
}