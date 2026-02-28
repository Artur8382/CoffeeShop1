// See https://aka.ms/new-console-template for more information
using System.Net;

//2.2 is in the order class

//2.3
static List<(string ProductName, int TotalQuantitySold)> GetPopularProducts(List<Order> orders)
{
    return orders
        .SelectMany(o => o.OrderItems)
        .GroupBy(oi => oi.ProductName)
        .Select(g => (ProductName: g.Key, TotalQuantitySold: g.Sum(oi => oi.Quantity)))
        .OrderByDescending(x => x.TotalQuantitySold)
        .ToList();
}

//2.4
static string GetTopBuyer(List<User> users)
{
    return users
        .OrderByDescending(u => u.Orders?
            .Sum(o => o.CalculateFinalPrice()) ?? 0)
        .FirstOrDefault()
        ?.Name ?? "No users found";
}

