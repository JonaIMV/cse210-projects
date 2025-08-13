// SimpleGoal.cs
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            return Points;
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
            return 0;
        }
    }

    public override string GetStatus()
    {
        string status = IsComplete ? "[X]" : "[ ]";
        return $"{status} {Name} ({Description})";
    }
}
