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
        _goalTitle = Console.ReadLine();
        Console.Write("\nWhat is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("\nHow many points is this goal worth? ");
        _points = int.Parse(Console.ReadLine());
        _complete = false;
        return (_goalTitle,_goalDescription,_points,_complete);
        
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
    protected virtual void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_goalTitle} ({_goalDescription})");
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