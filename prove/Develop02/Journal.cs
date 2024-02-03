using System.Collections.Generic;
using System.IO;

namespace Develop2;

public class Journal : IEnumerable<Entry>
{
    private List<Entry> entries = new();

    public Journal()
    {

    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        Console.WriteLine();
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }
        
        foreach (Entry entry in entries)
        {
            string[] parts = entry.EntryToString().Split("|");
            Console.WriteLine($"{parts[0]}\n{parts[1]}\n{parts[2]}");
            
        }
    }

    public void LoadJournalFromFile(string filename)
    {
        string[] lines = ReadFile(filename);

        foreach (string line in lines)
        {
            Entry entry = Entry.CreateEntryFromString(line);
            AddEntry(entry);
        }
        Console.WriteLine($"Journal loaded from file {filename}");
        
    }

    public string[] ReadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        return lines;
    }

    public void SaveJournalToFile(Journal journal,string filename)
    {
        
        using (StreamWriter outputFile = new(filename))
        {
            foreach (Entry entry in journal)
            {
                outputFile.WriteLine(entry.EntryToString());
            }
        }
        Console.WriteLine($"Journal saved to file {filename}");

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