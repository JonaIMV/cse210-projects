using System;

public abstract class Goal
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Points { get; private set; }
    public bool IsComplete { get; protected set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsComplete = false;
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();

    // Muestra el estado + datos de la meta
    public virtual string GetDetailsString()
    {
        return $"{GetStatus()}";
    }

    // Serializa en un formato simple
    public virtual string Serialize()
    {
        return $"{GetType().Name}|{Name}|{Description}|{Points}|{IsComplete}";
    }

    // Deserializa y crea el tipo correcto de meta
    public static Goal Deserialize(string data)
    {
        var parts = data.Split('|');
        if (parts.Length < 5) return null;

        string type = parts[0];
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        bool isComplete = bool.Parse(parts[4]);

        switch (type)
        {
            case "SimpleGoal":
                {
                    var g = new SimpleGoal(name, description, points);
                    g.IsComplete = isComplete;
                    return g;
                }
            case "EternalGoal":
                {
                    var g = new EternalGoal(name, description, points);
                    g.IsComplete = isComplete; // en práctica siempre false, pero lo mantenemos coherente
                    return g;
                }
            case "ChecklistGoal":
                {
                    // Orden esperado por Serialize(): ... | CurrentCount | TargetCount | BonusPoints
                    if (parts.Length < 8) return null;

                    int current = int.Parse(parts[5]);
                    int target = int.Parse(parts[6]);
                    int bonus = int.Parse(parts[7]);

                    var g = new ChecklistGoal(name, description, points, target, bonus);
                    g.CurrentCount = current;   // ✅ restauramos progreso
                    g.IsComplete = isComplete;
                    return g;
                }
            default:
                return null;
        }
    }
}
