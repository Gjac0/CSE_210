using System.Collections.Generic;

namespace Develop2;

public class Journal : IEnumerable<Entry>
{
    private List<Entry> entries = new();

    public Journal()
    {

    }

    public Journal(string import)
    {

    }
    public void Display()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }
        
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }
    public void SaveJournalToFile(string filename)
    {
        Console.WriteLine($"Journal saved to file {filename}");
    }
    public void LoadJournalFromFile(string filename)
    {
        Console.WriteLine($"Journal loaded from file {filename}");
        
    }
        public string[] ReadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        return lines;
    }
    public void WriteFile(Journal journal, string filename)
    {
        using (StreamWriter outputFile = new(filename))
        {
            foreach(Entry entry in journal)
            {
                
            }
        }

    }
    public IEnumerator<Entry> GetEnumerator()
    {
        return entries.GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}