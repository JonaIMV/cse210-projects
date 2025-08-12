using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public class ReflectionActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time you helped someone in need.",
            "Recall a time when you overcame a challenge."
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself from this experience?"
        };

        public ReflectionActivity() 
            : base("Reflection Activity", "This activity will help you reflect on times in your life when you showed strength.") 
        { }

        public override void Run()
        {
            ShowStartingMessage();

            Random rand = new Random();
            Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
            Thread.Sleep(3000);

            foreach (var question in _questions)
            {
                Console.WriteLine(question);
                Thread.Sleep(5000);
            }

            ShowEndingMessage();
        }
    }
}
