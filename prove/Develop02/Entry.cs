using System;
using System.Collections.Generic;

namespace Develop2;

class Entry
{
    public string Response;
    public string Prompt;
    public string Date;
    public List<string> prompts = new List<string>{
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"};
    public Entry (string response, string date)
    {
        Response  = response;
        Prompt = prompts[new Random().Next(prompts.Count)];
        Date = date;
    }
    
    public Entry(string import)
    {

    }
    
    public void Display()
    {
        Console.WriteLine($"{Date}\n{Prompt}\n{Response}");
    }
}
