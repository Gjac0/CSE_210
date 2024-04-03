namespace Foundation03;
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string eventTitle,string description,string date,string time,Address address,string speaker,int capacity):base(eventTitle,description,date,time,address)
    {
        _eventType = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }
    public override void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"Speaker: {_speaker}\nCapacity: {_capacity}");
    }
}