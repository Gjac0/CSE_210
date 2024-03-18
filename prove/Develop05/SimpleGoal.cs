
namespace Develop05;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        _classTitle = "SimpleGoal";
    }
    public SimpleGoal(string goalTitle,string goalDescription,int points, bool complete):base(goalTitle,goalDescription,points)
    {
        _complete = complete;
        _classTitle = "SimpleGoal";
    }
    public override SimpleGoal CreateFromString(string line, string DELIMITER)
    {
        string[] parts = line.Split(DELIMITER);
        string goalTitle = parts[1];       
        string goalDescription = parts[2];        
        int points = int.Parse(parts[3]);
        bool complete = bool.Parse(parts[4]);
        return new SimpleGoal(goalTitle, goalDescription, points,complete);
    }
    public override (string, string, int, bool) CreateNewGoal()
    {
        return base.CreateNewGoal();
    }
    public override void DisplayGoal()
    {
        base.DisplayGoal();
    }
    public override int CompleteGoal()
    {
        return base.CompleteGoal();
    }
    public override void ExportToFile(StreamWriter fileName, string DELIMITER)
    {
        base.ExportToFile(fileName, DELIMITER);
    }
}