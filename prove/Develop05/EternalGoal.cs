namespace Develop05;

public class EternalGoal : Goal
{
    public EternalGoal(){}
    public EternalGoal(string goalDescription,string goalTitle, int points):base(goalTitle,goalDescription,points){}
    public override (string, string, int, bool) CreateNewGoal()
    {
        return base.CreateNewGoal();
    }   

}