namespace Develop05;

public class Goal
{
    protected string _goalTitle;
    protected string _goalDescription;
    protected int _points;
    protected bool _complete = true;
    public Goal(string goalTitle,string goalDescription, int points)
    {
        _goalTitle = goalTitle;
        _goalDescription = goalDescription;
        _points = points;
    }
    public virtual void ExportToFile()
    {

    }
    public virtual Goal CreateFromFile()
    {
        // Console.Write("What type of goal would you like to create? ");
        Console.Write("\nWhat is the name of your goal? ");
        string goalTitle = Console.ReadLine();
        Console.Write("\nWhat is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("\nHow many points is this goal worth? ");
        int points = int.Parse(Console.ReadLine());
        return new Goal(goalTitle,goalDescription,points);
    }
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_goalTitle} ({_goalDescription})");
    }
    public virtual void CompleteGoal()
    {
        _complete = false;
    }
}