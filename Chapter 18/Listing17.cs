// ---- Code Listing 17 ----
using System.Reflection;

public static class Listing17
{
    public static void Run()
    {
        Type myType = typeof(string);
        var methods = myType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
