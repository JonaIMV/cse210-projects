using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    public int Score { get; private set; }

    public GoalManager()
    {
        _goals = new List<Goal>();
        Score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        Console.Clear();
        Console.WriteLine("=== Your Goals ===");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal selection.");
            return;
        }

        int pointsEarned = _goals[goalIndex].RecordEvent();
        Score += pointsEarned;

        Console.WriteLine($"Event recorded! You earned {pointsEarned} points.");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(Score); // First line: current score
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            Score = int.Parse(reader.ReadLine());

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Goal goal = Goal.Deserialize(line);
                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }
        }
    }
}
