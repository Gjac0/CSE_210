namespace Develop3;
public class Scripture
    {
        private string book;
        private int chapter;
        private List<Word> words;
        private List<string> hiddenWords;

        public bool AllWordsHidden => hiddenWords.Count == words.Count;

        public Scripture(string book, int chapter, string verses, string text)
        {
            this.book = book;
            this.chapter = chapter;
            this.words = new List<Word>();
            this.hiddenWords = new List<string>();

            ParseVerses(verses);
            ParseText(text);
        }

        private void ParseVerses(string verseString)
        {
            string[] parts = verseString.Split('-');
            int startVerse = int.Parse(parts[0]);
            int endVerse = parts.Length > 1 ? int.Parse(parts[1]) : startVerse;

            for (int verse = startVerse; verse <= endVerse; verse++)
            {
                words.Add(new Word($"{book} {chapter}:{verse}"));
            }
        }

        private void ParseText(string text)
        {
            string[] textWords = text.Split(' ');
            foreach (var word in textWords)
            {
                words.Add(new Word(word));
            }
        }

        public void DisplayScripture()
        {
            foreach (var word in words)
            {
                Console.Write(word.GetDisplayText() + " ");
            }
        }

        public void HideRandomWord()
        {
            Random rand = new Random();
            List<Word> wordsToHide = words.Where(word => !word.IsHidden()).ToList();
            Word wordToHide = wordsToHide[rand.Next(wordsToHide.Count)];
            
            wordToHide.Hide();
            hiddenWords.Add(wordToHide.GetWord());
        }
    }
