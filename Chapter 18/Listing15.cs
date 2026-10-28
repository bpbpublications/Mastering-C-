// ---- Code Listing 15 ----
using System.Linq.Expressions;

public class Product
{
    public decimal Price { get; set; }
}

public static class Listing15
{
    public static void Run()
    {
        var param = Expression.Parameter(typeof(Product), "p");
        var body = Expression.Property(param, nameof(Product.Price));
        var getter = Expression.Lambda<Func<Product, decimal>>(body, param).Compile();

        var product = new Product() { Price = 99.5M };
        Console.WriteLine($"Price = {getter(product)}");
    }
}
