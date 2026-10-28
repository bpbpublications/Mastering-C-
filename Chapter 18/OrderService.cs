// ---- Code Listing 7 (type declaration) ----
public class OrderService
{
    [Log("Order created.")]
    public void CreateOrder(int orderId) => Console.WriteLine($"Order {orderId} created");

    [Log("Order cancelled")]
    public void CancelOrder(int orderId) => Console.WriteLine($"Order {orderId} cancelled");

    [Log("Order shipped")]
    public void ShipOrder(int orderId) => Console.WriteLine($"Order {orderId} shipped");
}
