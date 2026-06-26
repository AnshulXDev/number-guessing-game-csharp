// -----------------number guessing game-------------------------

Random random = new Random();

int min = 0;
int randomNum;
int max = 101;
String response;
int guesses;
int userGuess;
bool playGame = true;

while (playGame)
{
    guesses = 0;
    userGuess = 0;
    randomNum = random.Next(min, max);
    response = "";

    while (userGuess != randomNum)
    {
        System.Console.Write($"Guess the number between {min} to {max-1}: ");
        userGuess = int.Parse(Console.ReadLine()!);

        if (userGuess > randomNum)
        {
            System.Console.WriteLine("Your number is greater than the actual number!");
        }

        else if (userGuess < randomNum)
        {
            System.Console.WriteLine("Your number is less than the actual number!");
        }

        guesses++;
    }
    System.Console.WriteLine("\nYahoo! You get it.");
    System.Console.WriteLine("The number is " + randomNum);

    System.Console.Write("Do you want to play again?(Y/N): "); //user output could be y instead of Y
    response = Console.ReadLine()!;
    response = response.ToUpper();

    if (response == "Y" || response == "YES")
    {
        playGame = true;
    }
    else if (response == "N" || response == "NO")
    {
        playGame = false;
    }
    else
    {
        System.Console.WriteLine("Invalid choice!");
    }
}

Console.ReadKey();
