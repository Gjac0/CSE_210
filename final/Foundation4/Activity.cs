using Microsoft.VisualBasic;

namespace Foundation04;
public abstract class  Activity
{
    protected string _date;
    protected double _length;
    protected Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    protected virtual double GetDistance
    
    ()
    {

        return 1.0;
    }
    protected virtual double GetSpeed()
    {
        return 1.0;
    }
    protected virtual double GetPace()
    {
        return 1.0;
    }
    protected virtual void GetSummary()
    {

    }
}