using System;

class Program
{
    static void Main()
    {
        DisplayWelcome();

        string name = PropmptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);

        DisplayResult(name, squared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Square Number Program!");
    }
    static string PropmptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        int number;
        bool IsValid = false;

        do
        {
            Console.Write("What is your favorite number?: ");
            string input = Console.ReadLine();
            IsValid = int.TryParse(input, out  number);

            if (!IsValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } while (!IsValid);
        return number;

    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"Hello {name},the square of your favorite number is {squared}.");

    }
}