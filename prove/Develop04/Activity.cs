namespace Develop04;

public class Activity
{   
    protected string ActivityName;  
    protected string Description;
    protected int Time;
    protected Activity()
    {
    }

    protected void IntroMessage()
    {
        Console.Clear();
        Console.Write($"Welcome to the {ActivityName}.\n\n{Description}\n\nHow long, in seconds, would you like your session? ");
        Time = int.Parse(Console.ReadLine());
    }

    protected void EndingMessage()
    {
        Console.WriteLine($"You have completed another {Time} seconds of the {ActivityName}.");
    }

    protected void LoadingAnimation()
    {
        Console.WriteLine("Get Ready...");

        for(int i = 0; i<3; i++)
        {
            List<char> chars =  new(){'/','-','\\','|'};
            foreach (char c in chars)
            {
                Console.Write("\b" + c);
                Thread.Sleep(100);
            }
        }
        Console.Write("\r \r\n");
    }
}