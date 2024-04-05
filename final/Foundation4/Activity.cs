using Microsoft.VisualBasic;

namespace Foundation04;
public abstract class  Activity
{
    protected string _date;
    protected double _length;
    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name:0.0} ({_length} min)- ";
    }
}