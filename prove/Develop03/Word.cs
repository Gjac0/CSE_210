// using System.Runtime.CompilerServices;
// namespace Develop3;

// public class Word
// {
//     private string word;
//     private bool hidden;

//     public Word(string word)
//     {
//         this.word = word;
//         hidden = false;
//     }

//     public void HideWord()
//     {
//         hidden = true;
//     }

//     public bool CheckHide()
//     {
//         return hidden;
//     }

//     public void DisplayWord()
//     {
//         if (hidden)
//         {
//             Console.Write($"{new string('_', word.Length)} ");
//         }
//         else
//         {
//             Console.Write($"{word} ");
//         }
//     }
// }