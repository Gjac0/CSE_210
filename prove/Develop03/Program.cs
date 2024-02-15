using System;
using Microsoft.VisualBasic.FileIO;
namespace Develop3;
class Program
{
    static void Main(string[] args)
    {
        string FilePath = "lds-scriptures.csv";
        Word word = new("Hello World");
        word.DisplayWord();
        word.HideWord();
        word.DisplayWord();
    }
    public static string[] ReadCsv()
    {
        using (TextFieldParser parser = new TextFieldParser(FilePath))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            
        }
    }
}