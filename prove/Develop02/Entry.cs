using System;
using System.Collections.Generic;

namespace Develop2;

public class Entry
{
    public string response;
    public string prompt;
    public DateTime date;
    public List<string> prompts = new List<string>{
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"};
    public Entry()
    {
        
    }
    public Entry (string response, DateTime date,string prompt)
    {
        this.date = date;
        this.response = response;
        this.prompt = prompt;
    }
    
    public Entry(string import)
    {
        
    }
    public Entry WriteNewEntry(DateTime date)
    {
        prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);
        response = Console.ReadLine();
        Entry entry = new(response,date,prompt);
        return entry;
    }
    public void Display()
    {
        Console.WriteLine($"{date}\n{prompt}\n{response}");
    }
}
