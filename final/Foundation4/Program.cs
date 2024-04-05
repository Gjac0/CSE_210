using System;
namespace Foundation04;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new();
        activities.Add(new Running("13 May 2024", 30, 3.0));
        activities.Add(new Cycling("14 May 2024", 30, 6.0));
        activities.Add(new Swimming("20 May 2024", 30, 20));

        // Displaying summary information
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}