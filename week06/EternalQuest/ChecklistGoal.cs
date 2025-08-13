public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }     // Número de veces necesarias
    public int CurrentCount { get; set; }            // Veces completadas hasta ahora
    public int BonusPoints { get; private set; }     // Puntos extra al completar

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override int RecordEvent()
    {
        CurrentCount++;
        if (CurrentCount >= TargetCount)
        {
            IsComplete = true;
            return Points + BonusPoints;
        }
        return Points;
    }

    public override string GetStatus()
    {
        string status = IsComplete ? "[X]" : "[ ]";
        return $"{status} {Name} ({Description}) -- Completed {CurrentCount}/{TargetCount}";
    }

    public override string Serialize()
    {
        return $"{GetType().Name}|{Name}|{Description}|{Points}|{IsComplete}|{CurrentCount}|{TargetCount}|{BonusPoints}";
    }
}

