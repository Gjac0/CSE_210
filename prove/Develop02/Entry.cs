using System;
using System.Collections.Generic;

namespace Develop2;

public class Entry
{
    public string Response;
    public string Prompt;
    public string Date;
    public static List<string> Prompts = new()
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

    public static Entry EntryFromUserInput()
    {
        string date = Program.GetDate(); 
        string prompt = Prompts[new Random().Next(Prompts.Count)];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        return new Entry(date, prompt, response);
    }
    public string EntryToString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }
}
    