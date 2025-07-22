// This function reads the scriptures from a text file called "scriptures.txt".
// It expects each line to have the format: Reference|Scripture text.
// It creates Scripture objects from each line and adds them to a list.
// If there is any problem reading the file, it shows an error message.
// This way, we can easily add more scriptures without changing the code.


using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found in the file.");
            return;
        }

        bool keepGoing = true;
        Random random = new Random();

        while (keepGoing)
        {
            int index = random.Next(scriptures.Count);
            Scripture scripture = scriptures[index];

            
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to start hiding words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                keepGoing = false;
                break;
            }

            
            while (!scripture.AllWordsHidden())
            {
                Console.Clear();
                scripture.HideRandomWords(3); 
                Console.WriteLine(scripture.GetDisplayText());

                Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
                input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    keepGoing = false;
                    break;
                }
            }

            if (!keepGoing)
            {
                break;
            }

            
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("All words are now hidden. Good job!");

            Console.WriteLine("Would you like to memorize another scripture? (yes to continue, quit to exit)");
            input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                keepGoing = false;
            }
        }

        Console.WriteLine("Thanks for using Scripture Memorizer. Goodbye!");
    }

    static List<Scripture> LoadScripturesFromFile(string fileName)
    {
        List<Scripture> scriptures = new List<Scripture>();

        try
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    Reference reference = Reference.Parse(parts[0]);
                    Scripture scripture = new Scripture(reference, parts[1]);
                    scriptures.Add(scripture);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }

        return scriptures;
    }
}
