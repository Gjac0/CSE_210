namespace Foundation03;

public class Reception : Event
{
    private string _rsvpEmail;
    public Reception(string eventTitle,string description,string date,string time,Address address,string rsvpEmail):base(eventTitle,description,date,time,address)
    {
        _eventTitle = "Reception";
        _rsvpEmail = rsvpEmail;
    }
    public override void FullDetails()
    {
        base.FullDetails();
        Console.Write(_rsvpEmail + "\n");
    }
}
