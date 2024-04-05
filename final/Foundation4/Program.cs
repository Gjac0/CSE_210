using System;
namespace Foundation04;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new(){
        new Running("13 May 2024", 30, 3.0),
        new Cycling("14 May 2024", 30, 6.0),
        new Swimming("20 May 2024", 30, 20)};

        // Displaying summary information
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}