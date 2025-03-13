namespace EasyOrderAPI.Models;
public class OrderModel
{
    public OrderModel(string name, string product, int quantity, double total)
    {
        Id = Guid.NewGuid();
        Name = name;
        Product = product;
        Quantity = quantity;
        Total = total;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Product { get; set; }
    public int Quantity { get; set; }
    public double Total { get; set; }
}
