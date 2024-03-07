namespace Develop04;

/// <summary>
/// _activityName, _description, _time;
/// </summary>
public class Activity
{   
    protected string _activityName;  
    protected string _description;
    protected int _time;
    protected List<string> _prompts;
    public Activity()
    {
    }

    protected void IntroMessage()
    {
        PauseAnimation(500);
        Console.Clear();
        Console.Write($"Welcome to the {_activityName}.\n\n{_description}\n\nHow long, in seconds, would you like your session? ");
        _time = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    protected void EndingMessage()
    {
        Console.WriteLine($"You have completed another {_time} seconds of the {_activityName}.");
    }

    protected void LoadingAnimation()
    {
        Console.WriteLine("Get Ready...");
        PauseAnimation(500);

    }
    public void Countdown()
    {
        for (int j = 5; j>0;j--)
        {   
            Console.Write("\b"+j);
            Thread.Sleep(1000); 
        }
        Console.Write("\b \n");
    }
    /// <summary>
    ///  Shows a spinning line for pause_time miliseconds. Takes 500 miliseconds for one full cycle.
    /// </summary>
    public void PauseAnimation(float pause_time)
    {
        List<char> chars =  new(){'/','-','\\','|'};
        for(int i = 0; i < (pause_time/500); i++)
        {
            foreach (char c in chars)
            {
                Console.Write("\b" + c);
                Thread.Sleep(125);
            }
        }
        Console.Write("\b \b");
    }

}