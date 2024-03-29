using System;
using System.Linq;
using System.Runtime.CompilerServices;
namespace Foundation1;
class Program
{
    static List<Video> videos = new();
    static void Main(string[] args)
    {
    
        Comment[] comments1 = {
            new("User1", "Great video!"),
            new("User2", "I learned a lot from this."),
            new("User3", "Thanks for sharing!")
        };
        
        Comment[] comments2 = {
            new("User4", "Interesting content."),
            new("User5", "Looking forward to more videos."),
            new("User6", "Very helpful, thank you!")
        };
        
        Comment[] comments3 = {
            new("User7", "This was exactly what I needed."),
            new("User8", "Keep up the good work!"),
            new("User9", "I'll definitely share this.")
        };
        videos.Add(new Video("Video 1", "Author 1", 156, comments1));
        videos.Add(new Video("Video 2", "Author 2", 276, comments2));
        videos.Add(new Video("Video 3", "Author 3", 343, comments3));
        
        foreach(Video video in videos)
        {
           video.DisplayVideo();
            Console.WriteLine();
        }
    }
}