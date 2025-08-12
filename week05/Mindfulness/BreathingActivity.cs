using System;
using System.Threading;

namespace MindfulnessApp
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() 
            : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.") 
        { }

        public override void Run()
        {
            ShowStartingMessage();

            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("Breathe in...");
                Thread.Sleep(4000);
                Console.WriteLine(" now breathe out...");
                Thread.Sleep(4000);
            }

            ShowEndingMessage();
        }
    }
}
