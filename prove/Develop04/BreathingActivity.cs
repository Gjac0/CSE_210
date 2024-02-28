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

        LoadingAnimation();
        BreatheAnimation();

        EndingMessage();
    }
    private void BreatheAnimation()
    {
        int loops = Time/10; 

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