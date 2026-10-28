// ---- Code Listing 19 ----
using System.Reflection;

public class Customer
{
    public string Name { get; set; } = "Alice";
}

public static class Listing19
{
    public static void Run()
    {
        Type type = typeof(Customer);
        PropertyInfo? customerName = type.GetProperty("Name");

        if (customerName != null)
        {
            var customer = new Customer();
            Console.WriteLine(customerName.GetValue(customer));
        }
    }
}
