using EasyOrderAPI.Models;

namespace EasyOrderAPI.Routes;

public static class OrderRoute
{
    private static readonly List<OrderModel> orders = new();
    public static void OrderRoutes(this WebApplication app)
    {
        var route = app.MapGroup("api/pedidos");

        route.MapGet("/", () => Results.Ok(orders));

        route.MapPost("/", (OrderRequest request) =>
        {
            var order = new OrderModel(request.name, request.product, request.quantity, request.total);
            orders.Add(order);
            return Results.Created($"/api/pedidos/{orders.Count - 1}", order);
        });
    }
}