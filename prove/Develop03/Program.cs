using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

namespace Develop3
{
 class Program
    {
        static void Main(string[] args)
        {
            List<Scripture> scriptures = new List<Scripture>();
            
            // User input for scripture
            Console.WriteLine("Enter the scripture reference:");
            Console.Write("Book: ");
            string book = Console.ReadLine();
            Console.Write("Chapter: ");
            string chapter = Console.ReadLine();
            Console.Write("Verse(s): ");
            string verseInput = Console.ReadLine();

            // Parse verse input
            List<int> verses = ParseVerses(verseInput);

            // Load scripture
            var reference = new Reference("User Input", book, chapter, verseInput);
            var words = LoadScriptureWords(book, chapter, verses);
            var scripture = new Scripture(words, reference);
            scriptures.Add(scripture);

            // Display and hide words
            DisplayScripture(scripture);
            while (!scripture.AllWordsHidden())
            {
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    return;
                else
                    HideRandomWord(scripture);
            }
        }

        public static List<int> ParseVerses(string verseInput)
        {
            List<int> verses = new List<int>();
            string[] parts = verseInput.Split('-');
            int startVerse = int.Parse(parts[0]);
            verses.Add(startVerse);
            if (parts.Length > 1)
            {
                int endVerse = int.Parse(parts[1]);
                for (int i = startVerse + 1; i <= endVerse; i++)
                {
                    verses.Add(i);
                }
            }
            return verses;
        }

        public static List<Word> LoadScriptureWords(string book, string chapter, List<int> verses)
        {
            // Here you would implement the logic to load words from your source
            // For demonstration purposes, I'll just generate some dummy words
            List<Word> words = new List<Word>();
            foreach (int verse in verses)
            {
                words.AddRange($"This is a dummy verse {book} {chapter}:{verse}".Split(' ').Select(w => new Word(w)));
            }
            return words;
        }

        public static void DisplayScripture(Scripture scripture)
        {
            scripture.Display();
        }

        public static void HideRandomWord(Scripture scripture)
        {
            Random rand = new Random();
            var visibleWords = scripture.GetVisibleWords();
            if (visibleWords.Any())
            {
                int index = rand.Next(visibleWords.Count);
                visibleWords[index].HideWord();
                DisplayScripture(scripture);
            }
        }
    }
    public class Reference
    {
        public string Volume { get; private set; }
        public string Book { get; private set; }
        public string Chapter { get; private set; }
        public string Verse { get; private set; }

        public Reference(string volume, string book, string chapter, string verse)
        {
            Volume = volume;
            Book = book;
            Chapter = chapter;
            Verse = verse;
        }
    }

    public class Scripture
    {
        private List<Word> words;
        public Reference Reference { get; private set; }

        public Scripture(List<Word> words, Reference reference)
        {
            this.words = words;
            Reference = reference;
        }

        public List<Word> GetVisibleWords()
        {
            return words.Where(word => !word.CheckHide()).ToList();
        }

        public bool AllWordsHidden()
        {
            return words.All(word => word.CheckHide());
        }

        public void Display()
        {
            Console.Clear();
            foreach (var word in words)
            {
                word.DisplayWord();
            }
            Console.WriteLine("\nReference: " + Reference.Volume + " " + Reference.Book + " " + Reference.Chapter + ":" + Reference.Verse);
        }
    }

    public class Word
    {
        private string word;
        public bool Hidden { get; private set; }

        public Word(string word)
        {
            this.word = word;
            Hidden = false;
        }

        public void HideWord()
        {
            Hidden = true;
        }

        public bool CheckHide()
        {
            return Hidden;
        }

        public void DisplayWord()
        {
            if (Hidden)
                Console.Write($"{new string('_', word.Length)} ");
            else
                Console.Write($"{word} ");
        }
    }
}
