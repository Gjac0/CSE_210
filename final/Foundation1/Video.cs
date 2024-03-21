using System.ComponentModel.DataAnnotations;

namespace Foundation1;

public class Video
{
    private string _title;
    private string _author;
    private int _time;
    private Comment[] _comments;
    public Video (string title,string author, int time, Comment[] comments)
    {
        _title = title;
        _author = author;
        _time = time;
        _comments = comments;
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} by {_author} {_time/60}:{_time%60}");
        foreach(Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}