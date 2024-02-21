namespace Learning04;
public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    //     private string _studentName;
    //     private string _topic;


    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name,topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
        // _studentName = name;
        // _topic = topic;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}