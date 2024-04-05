namespace Foundation04;
public class Swimming : Activity
{
    private int _laps; // number of laps

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; // kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (base._length / 60.0); // kilometers per hour
    }

    public override double GetPace()
    {
        return base._length / (_laps * 50 / 1000.0); // minutes per kilometer
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}