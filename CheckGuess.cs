namespace NumbersGame;
public class CheckGuess
{
    
   //CHeckGuess method in CheckGuess class, if elseif loop
    public CheckGuess(int guess, int randomNumber)
    {
        if (guess == randomNumber)
        {
            Console.WriteLine($"Grattis! {guess} var rätt nummer!");
        }
        else if (guess < randomNumber)
        {
            RandomAnswerLow();
        }
        else if (guess > randomNumber)
        {
            RandomAnswerHigh();
        }
        else if ((guess < randomNumber || guess > randomNumber) && (guess == randomNumber + 1 || guess == randomNumber - 1))
        {
            Console.WriteLine("Varm! Varm! Varm! Du är så nära att det brinner!");
        }
        else
        {
            Console.WriteLine("False input, försök igen");
        }
    }
    
    //Method of random responses if answer is too low
    public void RandomAnswerLow()
    {
        Random random = new Random();
        
        
        int randomNumber = random.Next(1, 4);

        if (randomNumber == 1)
        {
            Console.WriteLine("Inte tillräckligt bra. För lågt. Försök igen");
        }
        else if (randomNumber == 2)
        {
            Console.WriteLine("Is that your best shot? För lågt. Försök igen");
        }
        else if (randomNumber == 3)
        {
             Console.WriteLine("Skämtar du? För lågt. Försök igen");
        }
    }
    
    //Method of random responses if answer is too high
    public void RandomAnswerHigh()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 4);

        if (randomNumber == 1)
        {
            Console.WriteLine("Inte tillräckligt bra. För högt. Försök igen");
        }
        else if (randomNumber == 2)
        {
            Console.WriteLine("Is that your best shot? För högt. Försök igen");
        }
        else if (randomNumber == 3)
        {
            Console.WriteLine("Skämtar du? För högt. Försök igen");
        }
    }
}