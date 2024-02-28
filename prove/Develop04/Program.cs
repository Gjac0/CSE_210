using System;
namespace Develop04;
class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Menu();
        }
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:\n\t1. Start breathing activity\n\t2. Start reflecting activity\n\t3. Start listing activity\n\t4. Quit");
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            BreathingActivity breathingActivity = new();
            breathingActivity.Breathe();
                break;
            case 2:
            ReflectionActivity reflectionActivity = new();
            reflectionActivity.Reflect();
                break;            
            case 3:
            // ListingActivity listingActivity = new();
            // listingActivity.List();
                break;            
            case 4:
            Environment.Exit(0);
                break;
        }
    }
}