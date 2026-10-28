// ---- Code Listing 13 ----
using System.Reflection;

public static class Listing13
{
    public static void Run()
    {
        Type type = typeof(Demo);

        var publicMethod = type.GetMethod(nameof(Demo.Visible), BindingFlags.Public | BindingFlags.Instance);
        var privateMethod = type.GetMethod("Hidden", BindingFlags.NonPublic | BindingFlags.Instance);

        Console.WriteLine($"Public method found: {publicMethod != null}");
        Console.WriteLine($"Private method found: {privateMethod != null}");
    }
}
