using System;

class Program
{
    static void Main()
    {
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("\nWelcome to the Magic Number Game!");
            Console.WriteLine("I have selected a magic number between 1 and 100.");
            Console.WriteLine("Try to guess the magic number!");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                guessCount++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine($"You've guessed the magic number {magicNumber} in {guessCount} tries!");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Goodbye!");
    }
}
