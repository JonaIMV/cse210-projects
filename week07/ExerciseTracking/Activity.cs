using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime _date;
    private double _lengthMinutes;

    public Activity(DateTime date, double lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public DateTime Date => _date;
    public double LengthMinutes => _lengthMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({LengthMinutes} min): " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.00} min per km";
    }
}
