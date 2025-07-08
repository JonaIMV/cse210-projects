using System;

class Program
{
    static void Main(string[] args)
    {
        AskName();
        AskAgeAndLocation();
        AskFoodAndMovies();
    }
    static void AskName()
    {
        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your names is {lastName}, {firstName} {lastName}.");
    }
    static void AskAgeAndLocation()
    {

        Console.Write("How old are you? ");
        string age = Console.ReadLine();
        Console.Write("Where are you living? ");
        string location = Console.ReadLine();

        Console.WriteLine($"You are {age} years old and you live in {location}.");
    }
    static void AskFoodAndMovies()
    {
        Console.Write("What is your favorite food? ");
        string food = Console.ReadLine();
        Console.Write("What is your favorite movie? ");
        string movie = Console.ReadLine();
        Console.Write("How many times have you watched it? ");
        int timesWatched = int.Parse(Console.ReadLine());

        if (timesWatched == 1)

        {
            Console.WriteLine($"Your favorite food is {food}, your favorite movie is {movie}, and you have watched it {timesWatched} time.");

        }
        else
        {
            Console.WriteLine($"Your favorite food is {food}, your favorite movie is {movie}, and you have watched it {timesWatched} times.");
        }
       
    }
}

   
  