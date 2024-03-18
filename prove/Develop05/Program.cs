using System;
using System.Runtime.CompilerServices;
namespace Develop05;
class Program
{
    private static List<Goal> goals = new();
    private static int pointTotal = 0;
    private static string DELIMITER = "~~";
    static void GetGoalType()
    {
        Console.Write("   1. Simple\n   2. Eternal\n   " +
        "3. Checklist\nWhat kind of goal do you want to add? ");
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
                goals.Add(new ChecklistGoal(goalTitle, goalDescription, points, complete){});
            break;        
        }
    }
    static int Menu()
    {
        Console.Write($"\nYou have {pointTotal} points.\nMenu Options: \n   1. Create New Goal" +
        "\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n" +
        "   6. Quit\nSelect a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }
    static void Main(string[] args)
    {
        Console.Clear();
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
                    Console.Write("What is the name of the file? ");
                    string fileName = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        foreach (Goal goal in goals)
                        {
                            goal.ExportToFile(outputFile, DELIMITER);
                        }
                    }
                break;
                case 4:
                    Console.Write("What is the name of the file? ");
                    fileName = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(fileName);

                    foreach (string line in lines)
                    {

                        if (line.Split(DELIMITER)[0] == "SimpleGoal")
                        {
                            goals.Add(new SimpleGoal().CreateFromString(line,DELIMITER));
                        }
                        else if (line.Split(DELIMITER)[0] == "EternalGoal")
                        {
                            goals.Add(new EternalGoal().CreateFromString(line,DELIMITER));
                        }
                        else if (line.Split(DELIMITER)[0] == "ChecklistGoal")
                        {
                            goals.Add(new ChecklistGoal().CreateFromString(line,DELIMITER));
                        }

                    }                
                break;

                case 5:
                        for (int i = 0; i < goals.Count; i++)
                        {
                            Console.Write($"{i+1} ");
                            goals[i].DisplayGoalTitle();
                        }
                        Console.Write("Which goal did you accomplish? ");
                        int choice  = int.Parse(Console.ReadLine());
                        pointTotal += goals[choice-1].CompleteGoal();
                        
                break;

                case 6:
                Environment.Exit(0);
                break;                
            }
            
        }
    }
}