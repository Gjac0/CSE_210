using System.Reflection.Metadata.Ecma335;

namespace Foundation02;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public float CalculateTotalCost()
    {
        float total = 5;
        foreach(Product product in _products)
        {
            total += product.Price();
        }
        if(_customer.IsUSA())
        {
            total += 30;
        }
        return total;
    }
    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += product.PackingLabel() + "\n";
        }
        return label;
    }
    public string ShippingLabel()
    {
        return _customer.ReturnName() + _customer.ShippingLabel();
    }    
}