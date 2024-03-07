using System.Reflection;
using System.Runtime.CompilerServices;

namespace Develop04;

public class BreathingActivity : Activity
{
    public BreathingActivity(): base()
    {
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Breathe()
    {
        IntroMessage();
        LoadingAnimation();
        BreatheAnimation();
        EndingMessage();
        PauseAnimation(4000);
    }
    private void BreatheAnimation()
    {
        int loops = _time/10; 

        for (int i = 0; i < loops; i++)
        {
            Console.Write("\nBreathe In..........");
            Countdown();
            Console.Write("Breathe Out.........");
            Countdown();
        }
    }
}