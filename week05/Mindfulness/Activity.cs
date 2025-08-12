using System;

namespace MindfulnessApp
{
    public abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void ShowStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}.\n");
            Console.WriteLine(_description);
            Console.Write("\nHow long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        public void ShowEndingMessage()
        {
            Console.WriteLine("\nWell done!");
            Console.WriteLine($"You have completed {_duration} seconds of {_name}.");
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }

        
        public abstract void Run();
    }
}
