namespace Develop05;

public class ChecklistGoal : Goal
{
    private int _completionTarget;
    private int _timesCompleted;
    private int _bonus;
    public ChecklistGoal()
    {
        _classTitle = "ChecklistGoal";
    }
    public ChecklistGoal(string goalTitle, string goalDescription, int points, bool complete):base(goalTitle,goalDescription,points)
    {
        _classTitle = "ChecklistGoal";        
        _complete = complete;
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _completionTarget = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[{(_complete ? "✓":" ")}] {_goalTitle} ({_goalDescription})"+
        $" -- Currently completed: {_timesCompleted}/{_completionTarget}");
    }
    public override (string, string, int, bool) CreateNewGoal()
    {
        return base.CreateNewGoal();
    }
    public override void ExportToFile(StreamWriter fileName, string DELIMITER)
    {
        fileName.WriteLine($"{_classTitle}{DELIMITER}{_goalTitle}{DELIMITER}{_goalDescription}{DELIMITER}{_points}{DELIMITER}{_complete}{DELIMITER}{_timesCompleted}{DELIMITER}{_completionTarget}{DELIMITER}{_bonus}");
    }
    public override ChecklistGoal CreateFromString(string line, string DELIMITER)
    {
        string[] parts = line.Split(DELIMITER);
        return new ChecklistGoal()
        {_goalTitle = parts[1],
         _goalDescription = parts[2],
        _points = int.Parse(parts[3]),
        _complete = bool.Parse(parts[4]),
        _completionTarget = int.Parse(parts[5]),
        _timesCompleted = int.Parse(parts[6]),
        _bonus = int.Parse(parts[7])
        };
    }
    public override int CompleteGoal()
    {
        _timesCompleted ++;
        if (_completionTarget == _timesCompleted)
        {
            return base.CompleteGoal() + _bonus;
        }
        else
        {
            return _points;
        }
    }
}