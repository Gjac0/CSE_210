namespace Foundation02;
public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool IsUSA()
    {
        return _address.IsUSA();
    }
    public string ShippingLabel()
    {
        return _address.ReturnAdress();
    }
    public string ReturnName()
    {
        return _name + "\n";
    }
}