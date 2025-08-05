using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Video video1 = new Video("C# Basics", "John Smith", 300);
        Video video2 = new Video("Learn LINQ", "Mary Johnson", 420);
        Video video3 = new Video("Programming Tips", "Carlos Ruiz", 210);

        
        video1.AddComment(new Comment("Luis", "Great video, thanks!"));
        video1.AddComment(new Comment("Anna", "Clear and concise."));
        video1.AddComment(new Comment("Peter", "Excellent explanation."));

        
        video2.AddComment(new Comment("Laura", "This saved me for an exam."));
        video2.AddComment(new Comment("Mike", "Great content, keep it up."));
        video2.AddComment(new Comment("Sophie", "Could use a few more examples."));

        
        video3.AddComment(new Comment("Andrew", "Such useful tips!"));
        video3.AddComment(new Comment("Carmen", "Helped me a lot."));
        video3.AddComment(new Comment("Diego", "I shared it with my classmates."));

        
        List<Video> videos = new List<Video> { video1, video2, video3 };

        
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Comments ({video.GetNumberOfComments()}):");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"  - {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(); 
        }
    }
}
