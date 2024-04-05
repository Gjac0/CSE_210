namespace Foundation04;
public class Cycling : Activity
{
    private double _speed; 

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed * (base._length / 60.0); 
    }

    public override double GetPace()
    {
        return 60 / _speed; 
    }
    public override string GetSummary()
    {
        return base.GetSummary() + $"Distance: {GetDistance()} miles, Speed: {_speed} mph, Pace: {GetPace()} min per mile";
    }
}
