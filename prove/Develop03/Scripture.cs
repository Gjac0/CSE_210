// namespace Develop3;
//  public class Scripture
//     {
//         private List<Word> words;
//         public Reference Reference { get; private set; }

//         public Scripture(List<Word> words, Reference reference)
//         {
//             this.words = words;
//             Reference = reference;
//         }

//         // Hide a random word that is not already hidden
//         public void HideRandomWord()
//         {
//             Random rand = new Random();
//             var visibleWords = words.Where(word => !word.CheckHide()).ToList();
//             if (visibleWords.Count > 0)
//             {
//                 int index = rand.Next(visibleWords.Count);
//                 visibleWords[index].HideWord();
//             }
//         }

//         // Check if all words are hidden
//         public bool AllWordsHidden()
//         {
//             return words.All(word => word.CheckHide());
//         }

//         // Display the scripture with hidden words
//         public void Display()
//         {
//             Console.Clear();
//             foreach (var word in words)
//             {
//                 word.DisplayWord();
//             }
//             Console.WriteLine("\nReference: " + Reference);
//         }
//     }
