using System.Diagnostics;

namespace Develop05;

public class Goal
{
    protected string _classTitle = "Goal";
    protected string _goalTitle;
    protected string _goalDescription;
    protected int _points;
    protected bool _complete;
    public Goal()
    {

    }
    public Goal(string goalTitle,string goalDescription, int points)
    {
        _goalTitle = goalTitle;
        _goalDescription = goalDescription;
        _points = points;
    }
    public virtual (string,string,int,bool) CreateNewGoal()
    {
        Console.Write("\nWhat is the name of your goal? ");
        string goalTitle = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        int points = int.Parse(Console.ReadLine());
        return (goalTitle,goalDescription,points,false);
    }
    public virtual void ExportToFile(string fileName,string DELIMITER)
    {
        new StreamWriter(fileName).WriteLine($"{_classTitle}{DELIMITER}{_goalTitle}{DELIMITER}{_goalDescription}{DELIMITER}{_points}{DELIMITER}{_complete}");
    }
    public virtual Goal CreateFromString(string line, string DELIMITER)
    {
        string[] parts = line.Split(DELIMITER);
        string goalTitle = parts[1];
        string goalDescription = parts[2];
        int points = int.Parse(parts[3]);
        bool complete = bool.Parse(parts[4]);
        return new Goal(goalTitle, goalDescription, points){_complete = complete};
    }
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[{(_complete ? "✓":" ")}] {_goalTitle} ({_goalDescription})");
    }
    public void DisplayGoalTitle()
    {
        Console.WriteLine(_goalTitle);
    }
    public virtual int CompleteGoal()
    {
        _complete = true;
        return _points;
    }
    protected static string GetFilename()
    {
        Console.Write("What is the name of the file? ");
        return Console.ReadLine();
    }
}