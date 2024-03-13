using System;
using System.Security.Cryptography.X509Certificates;
namespace Develop05;
class Program
{
    private static List<Goal> goals = new();
    static int pointTotal = 0;
    static void GetGoalType()
    {
        Console.WriteLine("   What kind of goal do you want to add?\n      1. Simple\n      2. Eternal\n      3. Checklist");
        switch(int.Parse(Console.ReadLine()))
        {
            case 1:
                var (simpleGoalTitle, simpleGoalDescription, simplePoints, simpleComplete) = new SimpleGoal().CreateNewGoal();
                goals.Add(new SimpleGoal(simpleGoalTitle, simpleGoalDescription, simplePoints, simpleComplete));
            break;
            case 2:
                var (eternalGoalTitle, eternalGoalDescription, eternalPoints, _) = new EternalGoal().CreateNewGoal();
                goals.Add(new EternalGoal(eternalGoalTitle, eternalGoalDescription, eternalPoints));
            break;            
            case 3:
                var (goalTitle, goalDescription, points, complete) = new ChecklistGoal().CreateNewGoal();
                goals.Add(new ChecklistGoal(goalTitle, goalDescription, points, complete));
            break;        
        }
    }
    static int Menu()
    {
        Console.Write($"\nYou have {pointTotal} points.\nMenu Options: \n   1. Create New Goal\n   2. List Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\n Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }
    static void Main(string[] args)
    {
        
        while (true)
        {
            switch(Menu())
            {
                case 1:
                GetGoalType();
                break;

                case 2:
                    foreach (Goal goal in goals)
                    {
                        goal.DisplayGoal();
                    }
                break;

                case 3:
                // SaveToFile();
                break;

                case 4:
                //  LoadFromFile();
                break;

                case 5:
                // RecordEvent();
                break;

                case 6:
                Environment.Exit(0);
                break;                
            }
            
        }
    }
}