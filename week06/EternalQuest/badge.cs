
public class Badge
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int PointsRequired { get; private set; }

    public Badge(string name, string description, int pointsRequired)
    {
        Name = name;
        Description = description;
        PointsRequired = pointsRequired;
    }

    public override string ToString()
    {
        return $"{Name} - {Description} (Requires {PointsRequired} pts)";
    }
}
