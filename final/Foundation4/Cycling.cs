namespace Foundation04;
public class Cycling : Activity
{
    private double _speed; 

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (base._length / 60.0); 
    }
    public override double GetPace()
    {
        return 60 / _speed; 
    }
    public override string GetSummary()
    {
        return base.GetSummary() + $"Distance: {GetDistance():0.0} miles, Speed: {_speed:0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
