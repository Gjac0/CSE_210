using System.Security.Cryptography.X509Certificates;

namespace Foundation02;

public class Product
{
    private string _name;
    private string _productId;
    private float _price;
    private int _quantity;
    public Product(string name, string productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public float Price()
    {
        return _price*_quantity;
    }
    public string PackingLabel()
    {
        return $"{_name} {_productId}";
    }
    
}