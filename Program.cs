// See https://aka.ms/new-console-template for more information

using NumbersGame;

//While loop to make the game loopable
bool gameOn = true;

while (gameOn)
{
    //Declare two variables that change depending on difficulty level
    int topNumber = 0;
    int tries = 0;
    
    Console.WriteLine("Pick a difficulty level between 1-5. 1 is easiest and 5 is hardest.");
    int level = Int32.Parse(Console.ReadLine());
    
    //Switch that changes difficulty level based on user selection
    switch (level)
    {
        case 1:
            topNumber = 16;
            tries = 5;
            break;
        case 2:
            topNumber = 21;
            tries = 5;
            break;
        case 3:
            topNumber = 26;
            tries = 4;
            break;
        case 4:
            topNumber = 31;
            tries = 4;
            break;
        case 5:
            topNumber = 36;
            tries = 3;
            break;
        default:
            Console.WriteLine("False input, please pick a number between 1-5");
            break;
    }
    
    //Random generator method
    Random random = new Random();
    int randomNumber = random.Next(1, topNumber);

    Console.WriteLine($"Välkommen! Jag tänker på ett nummer mellan 1 och {topNumber}. Kan du gissa vilket? Du få {tries} försök.");

    try
    {
        //Run game tries amount of times, accessing CheckGuess Constructor from CheckGuess Class
        for (int i = 0; i < tries; i++)
        {
            int guess = Int32.Parse(Console.ReadLine());
            CheckGuess guessChecker = new CheckGuess(guess, randomNumber);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    
    //Play Again
    Console.WriteLine("Vill du spela igen? Y/N");
    string response = Console.ReadLine();

    if (response.ToUpper() == "N")
    {
        gameOn = false;
    }

}

