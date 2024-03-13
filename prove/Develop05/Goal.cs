using System.Diagnostics;

namespace Develop05;

public class Goal
{
    protected string _goalTitle;
    protected string _goalDescription;
    protected int _points;
    protected bool _complete;
    string DELIMETER = "`~`";
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
    protected virtual void ExportToFile()
    {
        Console.Write("What is the name of the file? ");
        string fileName = Console.ReadLine();
        using StreamWriter outputFile = new(fileName);
        outputFile.WriteLine(_goalTitle, DELIMETER, _goalDescription, DELIMETER, _points, DELIMETER, _complete);

    }
    protected virtual Goal CreateFromString(string line)
    {
        string[] parts = line.Split(DELIMETER);
        string goalTitle = parts[0];
        string goalDescription = parts[1];
        int points = int.Parse(parts[2]);
        bool complete = bool.Parse(parts[3]);
        Goal goal = new(goalTitle, goalDescription, points)
        {
            _complete = complete
        };
        return goal;
    }
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[{(_complete ? " ":"✓")}] {_goalTitle} ({_goalDescription})");
    }
    protected virtual void CompleteGoal()
    {
        _complete = true;
    }
    protected static string GetFilename()
    {
        Console.Write("What is the name of the file? ");
        return Console.ReadLine();
    }
}