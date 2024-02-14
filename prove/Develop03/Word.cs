using System.Runtime.CompilerServices;
namespace Develop3;

public class Word
{
    private string word{get;set;}
    private bool hide{get;set;}
    public Word(string word)
    {
        this.word = word;
        hide = false;

    }
    
    public void HideWord()
    {
        hide = true;
    }
    public bool CheckHide()
    {
        return hide;
    }
    public void DisplayWord()
    {
        if (hide == true)
        {
            Console.WriteLine($"{new string('_', word.Length)} ");
        }
        else
        {
            Console.Write($"{word} ");
        }
    }
}

