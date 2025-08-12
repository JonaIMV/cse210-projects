using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "List as many things as you can that make you happy.",
            "List as many personal strengths you can think of."
        };

        public ListingActivity() 
            : base("Listing Activity", "This activity will help you list things related to positivity.") 
        { }

        public override void Run()
        {
            ShowStartingMessage();

            Random rand = new Random();
            Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
            Console.WriteLine("You may begin in:");
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            int count = 0;

            while (DateTime.Now < endTime)
            {
                Console.ReadLine();
                count++;
            }

            Console.WriteLine($"You listed {count} items.");
            ShowEndingMessage();
        }
    }
}
