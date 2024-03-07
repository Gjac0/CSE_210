using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Develop04;

public class ListingActivity : Activity
{
    public ListingActivity():base()
    {
        _activityName = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>{
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"};
    }
    public void Listing()
    {
        IntroMessage();

        Console.WriteLine($"List as many responses you can to the following prompt:\n ---{_prompts[new Random().Next(_prompts.Count)]}---");
        Console.Write("You may begin in:  ");
        Countdown();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        int count = 0;
        while(DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"\nYou listed {count} items.");
        EndingMessage();
        PauseAnimation(4000);
    }
}