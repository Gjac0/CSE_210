using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int magicNumber = rnd.Next(1,101);
        int guess;
        int count = 0;

        Console.WriteLine("Guess a number between 1-100");
        do {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            count++;

            if(guess>magicNumber){
                Console.WriteLine("Lower");
            }
            else if(guess<magicNumber){
                Console.WriteLine("Higher");
            }

        } while(guess != magicNumber);

        Console.WriteLine("You guessed it in {0} guesses!",count);
    }
}