public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, double lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50 / 1000.0; // km
    public override double GetSpeed() => (GetDistance() / LengthMinutes) * 60;
    public override double GetPace() => LengthMinutes / GetDistance();
}
