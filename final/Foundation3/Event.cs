namespace Foundation03;

public class Event
{
    protected string _eventType;
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    protected Event(string eventTitle,string description,string date,string time,Address address)
    {
        _eventType = "Event";
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public void StandardDetails()
    {
        Console.WriteLine($"\nTitle: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.ReturnAddress()}");
    }
    public virtual void FullDetails()
    {
        StandardDetails();
    } 
    public void ShortDescription()
    {
        Console.WriteLine($"\nEvent Type: {_eventType}\nTilte: {_eventTitle}\nDate: {_date}");
    }
}