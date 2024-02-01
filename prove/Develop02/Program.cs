namespace Develop2;
using System;

class Program
{
 static void Main()
    {
        Journal journal = new Journal();

        Console.Clear();
        while (true)
        {
            Console.WriteLine();
            ShowMenu();

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Entry entry = new Entry().WriteNewEntry();
                    journal.AddEntry(entry);
                    break;

                case 2:
                    journal.DisplayJournal();
                    break;

                case 3:
                    journal.SaveJournalToFile(journal,GetFilename());
                    break;

                case 4:
                    journal.LoadJournalFromFile(GetFilename());
                    break;

                case 5:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice (1-5): ", 1, 5);
    }
    public static string GetDate()
    {
        string date = DateTime.Today.ToString();
        return date;
    }
    static string GetFilename()
    {
        Console.Write("Please input the filename: ");
        string filename = Console.ReadLine();
        return filename;
    }
}

