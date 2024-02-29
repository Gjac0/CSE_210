namespace Develop04;

public class Activity
{   
    protected string ActivityName;  
    protected string Description;
    protected int Time;
    public Activity()
    {
    }

    protected void IntroMessage()
    {
        Console.Clear();
        Console.Write($"Welcome to the {ActivityName}.\n\n{Description}\n\nHow long, in seconds, would you like your session? ");
        Time = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    protected void EndingMessage()
    {
        Console.WriteLine($"You have completed another {Time} seconds of the {ActivityName}.");
    }

    protected void LoadingAnimation()
    {
        Console.WriteLine("Get Ready...");
        PauseAnimation(500);
        Console.Write("\n");
    }
    /// <summary>
    ///  Shows a spinning line for pauseTime miliseconds. Takes 500 miliseconds for one full.
    /// </summary>
    public void PauseAnimation(float pauseTime)
    {
        List<char> chars =  new(){'/','-','\\','|'};
        for(int i = 0; i < (pauseTime/500); i++)
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