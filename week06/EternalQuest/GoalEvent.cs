
using System;

public class GoalEvent
{
   
    public DateTime Date { get; private set; }
    public string GoalName { get; private set; }
    public int PointsEarned { get; private set; }

    public GoalEvent(string goalName, int pointsEarned)
    {
        GoalName = goalName;
        PointsEarned = pointsEarned;
        Date = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Date:G} - {GoalName} (+{PointsEarned} pts)";
    }
}
