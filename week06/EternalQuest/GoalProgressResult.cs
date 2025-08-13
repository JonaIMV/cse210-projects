
public class GoalProgressResult
{
    
    public int PointsEarned { get; private set; }
    public bool GoalCompleted { get; private set; }
    public string Message { get; private set; }

    public GoalProgressResult(int pointsEarned, bool goalCompleted, string message)
    {
        PointsEarned = pointsEarned;
        GoalCompleted = goalCompleted;
        Message = message;
    }
}
