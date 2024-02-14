using System;
namespace Develop3;
class Program
{
    static void Main(string[] args)
    {

        Word word = new("Hello World");
        word.DisplayWord();
        word.HideWord();
        word.DisplayWord();
    }
}