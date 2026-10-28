// ---- Code Listing 7 (executable part) ----
using System.Reflection;

public static class Listing07
{
    public static void Run()
    {
        var method = typeof(OrderService).GetMethod("CreateOrder")!;
        var attribute = method.GetCustomAttribute<LogAttribute>();
        Console.WriteLine($"Service Name: OrderService");
        Console.WriteLine($"Method Name: {method.Name}");
        Console.WriteLine($"Log Message: {attribute?.Message ?? "No data..."}");
    }
}
