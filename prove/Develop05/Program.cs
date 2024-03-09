using System;
namespace Develop05;
class Program
{
    static int Menu()
    {
        Console.Write("Menu Options: \n   1. Create New Goal\n   2. List Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\n Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }
    static void Main(string[] args)
    {
        while (true)
        {
            switch(Menu())
            {
                case 1:
                // CreateNewGoal();
                break;

                case 2:
                // ListGoals();
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