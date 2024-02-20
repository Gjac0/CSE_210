using System;
using System.Collections.Generic;
using System.Linq;

namespace Develop3;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Hiding Program!");

        Scripture scripture = new Scripture("Mosiah", 2, "41", "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.");

        while (!scripture.AllWordsHidden)
        {
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            scripture.HideRandomWord();
        }

        Console.WriteLine("Program ended.");

    }
}