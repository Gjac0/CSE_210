using System;
using System.Runtime.CompilerServices;
namespace Foundation02;
class Program
{
    protected static List<Order> orders = new();
    static void Main(string[] args)
    {         
        Product product1 = new Product("Widget", "W123", 10.37, 2);
        Product product2 = new Product("Gadget", "G456", 15.48, 3);
        Product product3 = new Product("Thingamajig", "T789", 8.99, 1);

        orders.Add(new Order(new List<Product> { product1, product2 },new Customer("John Doe", new Address("123 Main St", "Anytown", "CA", "USA"))));
        Console.WriteLine($"Added{orders}");
        orders.Add(new Order(new List<Product> { product2, product3 },new Customer("Jane Smith", new Address("456 Oak St", "Othertown", "PU", "Mexico"))));
        Console.WriteLine($"Added{orders}");

        foreach(Order order in orders)
        {
            Console.WriteLine($"\n{order.PackingLabel()}{order.ShippingLabel()}${order.CalculateTotalCost()}");
        }
    }
}