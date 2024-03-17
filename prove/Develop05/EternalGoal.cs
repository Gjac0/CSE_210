namespace Develop05;

public class EternalGoal : Goal
{
    public EternalGoal()
    {
        _classTitle = "EternalGoal";
    }
    public EternalGoal(string goalTitle,string goalDescription, int points):base(goalTitle,goalDescription,points)
    {
        _classTitle = "EternalGoal";
    }
    public override (string, string, int, bool) CreateNewGoal()
    {
        return base.CreateNewGoal();
    }
    public override void ExportToFile(string fileName, string DELIMITER)
    {
        using StreamWriter outputFile = new(fileName);
        outputFile.WriteLine($"{_classTitle}{DELIMITER}{_goalTitle}{DELIMITER}{_goalDescription}{DELIMITER}{_points}");        
    }
    public override EternalGoal CreateFromString(string line, string DELIMITER)
    {
        string[] parts = line.Split(DELIMITER);
        string goalTitle = parts[1];
        string goalDescription = parts[2];
        int points = int.Parse(parts[3]);
        return new EternalGoal(goalTitle, goalDescription, points);
    }
    public override int CompleteGoal()
    {
        return _points;
    }
}