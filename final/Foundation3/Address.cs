namespace Foundation03;
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address(string  street,string city, string state,string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country; 
    }
    public string ReturnAddress()
    {
        return $"\n\t{_street}\n\t{_city}\n\t{_state}\n\t{_country}";
    }
}