namespace Develop3;

public class Word
{
    private string word;
    private bool hidden;

    public Word(string word)
    {
        this.word = word;
        hidden = false;
    }
    public bool IsHidden()
    {
        return hidden;
    }
    
    public void Hide()
    {
        hidden = true;
    }
    public string GetWord()
    {
        return word;
    }

    public string GetDisplayText()
    {
        return hidden ? new string('_', word.Length) : word;
    }
}