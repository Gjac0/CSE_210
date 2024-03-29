namespace Foundation03;

public class Outdoor : Event
{
    private string _forecast;
    public Outdoor(string eventTitle,string description,string date,string time,Address address, string forecast):base(eventTitle,description,date,time,address)
    {
        _eventType = "Outdoor";
        _forecast = forecast;
    }
    public override void FullDetails()
    {
        base.FullDetails();
        Console.Write(_forecast + "\n");
    }
}