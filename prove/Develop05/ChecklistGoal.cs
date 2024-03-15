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
        Console.Write("How many times does this goal need to be accomplished fora bonus? ");
        _completionTarget = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[{(_complete ? "✓":" ")}] {_goalTitle} ({_goalDescription})"+
        $" -- Currently completed: {_completionTarget}/{_timesCompleted}");
    }
    public override (string, string, int, bool) CreateNewGoal()
    {
        return base.CreateNewGoal();
    }
    public override void ExportToFile(string fileName, string DELIMITER)
    {
        using StreamWriter outputFile = new(fileName);
        outputFile.WriteLine($"{_classTitle}{DELIMITER}{_goalTitle}{DELIMITER}{_goalDescription}{DELIMITER}{_points}{DELIMITER}{_complete}{DELIMITER}{_timesCompleted}{DELIMITER}{_completionTarget}{DELIMITER}{_bonus}");
    }
    public override ChecklistGoal CreateFromString(string line, string DELIMITER)
    {
        string[] parts = line.Split(DELIMITER);
        string goalTitle = parts[1];
        string goalDescription = parts[2];
        int points = int.Parse(parts[3]);
        bool complete = bool.Parse(parts[4]);
        int timesCompleted = int.Parse(parts[5]);
        int completionTarget = int.Parse(parts[6]);
        int bonus = int.Parse(parts[7]);
        return new ChecklistGoal(goalTitle, goalDescription, points, complete){_completionTarget = completionTarget, _timesCompleted = timesCompleted, _bonus = bonus};
    }
}