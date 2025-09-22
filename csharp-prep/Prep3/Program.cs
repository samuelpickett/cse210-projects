using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "y";
        while (play == "y")
        {
            Random numGenerator = new Random();
            int number = numGenerator.Next(0, 100);
            Console.Write("What is your guess for the magic number? ");
            int guess = int.Parse(Console.ReadLine());
            int numGuesses = 0;
            while (guess != number)
            {
                if (guess < number)
                {
                    Console.WriteLine("Higher");
                    numGuesses++;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                    numGuesses++;
                }
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You got it in {numGuesses} guesses. ");
            Console.Write("Would you like to play again? y/n");
            play = Console.ReadLine();
        }
    }
}