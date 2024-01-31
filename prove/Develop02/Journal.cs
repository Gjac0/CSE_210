namespace Develop2;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public Journal()
    {

    }

    Journal(string import)
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

    public string Export()
    {
        return "";
    }
}