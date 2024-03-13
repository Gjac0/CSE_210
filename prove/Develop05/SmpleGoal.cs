namespace Develop05;

public class SimpleGoal : Goal
{
    public SimpleGoal(){}
    public SimpleGoal(string goalDescription,string goalTitle,int points, bool complete):base(goalDescription,goalTitle,points)
    {
        _complete = complete;
    }
    public override (string, string, int, bool) CreateNewGoal()
    {
        return base.CreateNewGoal();
    }
}
