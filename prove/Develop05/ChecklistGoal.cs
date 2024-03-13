namespace Develop05;

public class ChecklistGoal : Goal
{
    private int _completionTarget;
    // private int _timesCompleted;
    public ChecklistGoal(){}
    public ChecklistGoal(string goalTitle, string goalDescription, int points, bool complete):base(goalTitle,goalDescription,points)
    {
        _complete = complete;
        Console.Write("How many times do you want to complete the goal? ");
        _completionTarget = int.Parse(Console.ReadLine());
    }
    public override (string, string, int, bool) CreateNewGoal()
    {
        return base.CreateNewGoal();
    }

}