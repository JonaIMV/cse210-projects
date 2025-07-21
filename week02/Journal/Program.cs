// I added a small extra feature to make the program more user-friendly.
// After loading the journal from a file, it now automatically shows all the entries
// without the user needing to pick the display option again.
// I thought this would save time and make it easier to check if the file was loaded correctly.



using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static List<string> prompts = new List<string>
    {
        "What did you learn today?",
        "What was the best part of your day?",
        "What challenges did you face today?",
        "What are you grateful for today?",
        "What goals do you have for tomorrow?"
    };
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        bool running = true;
        while (running)
        {
            Console.WriteLine("Welcome to your Journal!, please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice (1-5):");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Random rand = new Random();
                    string prompt = prompts[rand.Next(prompts.Count)];
                    Console.WriteLine(prompt);
                    Console.WriteLine("> ");
                    string response = Console.ReadLine();
                    myJournal.AddEntry(prompt, response);
                    break;

                case "2":
                    myJournal.Display();
                    break;

                case "3":
                    Console.WriteLine("Enter filename to save journal:");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved successfully.");
                    break;

                case "4":
                    Console.WriteLine("Enter filename to load journal:");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal loaded successfully.");
                    myJournal.Display();
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
            Console.WriteLine();
        } 
    }
   }