namespace Develop3;
public class Reference
{
    private string book;
    private int chapter;
    private int verseStart;
    private int? verseEnd;

    public Reference(string book, int chapter, int verseStart, int? verseEnd = null)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
    }
}