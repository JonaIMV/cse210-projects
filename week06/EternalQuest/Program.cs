using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Eternal Quest ===");
            Console.WriteLine($"Current Score: {goalManager.Score}");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goalManager);
                    break;
                case "2":
                    goalManager.ListGoals();
                    Pause();
                    break;
                case "3":
                    RecordEvent(goalManager);
                    break;
                case "4":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    goalManager.SaveGoals(saveFile);
                    Console.WriteLine("Goals saved!");
                    Pause();
                    break;
                case "5":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    goalManager.LoadGoals(loadFile);
                    Console.WriteLine("Goals loaded!");
                    Pause();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    Pause();
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine("Choose the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                goalManager.AddGoal(new SimpleGoal(name, description, points));
                break;

            case "2":
                goalManager.AddGoal(new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;

            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }

        Console.WriteLine("Goal created!");
        Pause();
    }

    static void RecordEvent(GoalManager goalManager)
    {
        goalManager.ListGoals();
        Console.Write("Select the goal number to record: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex))
        {
            goalManager.RecordEvent(goalIndex - 1);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}
