using System;
using System.Collections.Generic;

namespace Develop2;

public class Entry
{
    public string Response;
    public string Prompt;
    public string Date;
    public List<string> Prompts = new()
    {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
    };

    public Entry (string date,string prompt,string response)
    {
        this.Date = date;
        this.Response = response;
        this.Prompt = prompt;
    }
    
    public static Entry CreateEntryFromString(string import)
    {
        string[] entryString = import.Split("|");
        return new Entry(entryString[0],entryString[1],entryString[2]);
    }

    public Entry WriteNewEntry(string date)
    {
        Date = date; 
        Prompt = Prompts[new Random().Next(Prompts.Count)];
        Console.WriteLine(Prompt);
        Response = Console.ReadLine();
        return this;
    }
    public string EntryToString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }
}
    