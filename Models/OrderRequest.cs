namespace EasyOrderAPI.Models;
public record OrderRequest(string name, string product, int quantity, double total);