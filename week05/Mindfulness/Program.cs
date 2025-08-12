using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Select a choice from the menu: ");

                string choice = Console.ReadLine();

                Activity activity = null;

                switch (choice)
                {
                    case "1":
                        activity = new BreathingActivity();
                        break;
                    case "2":
                        activity = new ReflectionActivity();
                        break;
                    case "3":
                        activity = new ListingActivity();
                        break;
                    case "4":
                        running = false;
                        continue;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        Console.ReadKey();
                        continue;
                }

                if (activity != null)
                {
                    activity.Run();
                }
            }

            Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
        }
    }
}
