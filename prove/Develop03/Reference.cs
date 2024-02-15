namespace Develop3;
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