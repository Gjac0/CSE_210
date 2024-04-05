namespace Foundation04;

public class Running : Activity
{
    private double _distance;
    public Running(string date, double length, double distance):base(date,length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / (base._length / 60.0); 
    }
    public override double GetPace()
    {
        return base._length / _distance; 
    }
    public override string GetSummary()
    {
        return base.GetSummary() + $"Distance: {_distance:0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}