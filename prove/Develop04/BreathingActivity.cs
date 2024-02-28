using System.Reflection;
using System.Runtime.CompilerServices;

namespace Develop04;

public class BreathingActivity : Activity
{
    public BreathingActivity(): base()
    {
        ActivityName = "Breathing Activity";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Breathe()
    {
        IntroMessage();

        Console.Clear();
        LoadingAnimation();

        BreatheAnimation(Time);

        EndingMessage();
    }
    static void BreatheAnimation(int time)
    {
        int loops = time/10; 

        for (int i = 0; i < loops; i++)
        {
            Console.Write("\nBreathe In..........5");
            Thread.Sleep(1000);
            for (int j = 4; j>0;j--)
            {   
                Console.Write($"\b{j}");
                Thread.Sleep(1000); 
            }
            Console.Write("\b");
        
        Console.Write("\nBreathe Out.........5");
        Thread.Sleep(1000);
            for (int j = 4; j>0;j--)
            {   
                Console.Write($"\b{j}");
                Thread.Sleep(1000); 
            }
            Console.Write("\b");
            Console.Write("\n");
        }
    }
}