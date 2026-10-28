// ---- Code Listing 8 ----
using System.Reflection;

public class Author
{
    [Obsolete("Use GetFullName instead.")]
    public string GetName() => "Joydip Kanjilal";

    public string GetFullName() => "Joydip Kanjilal";
}

public static class Listing08
{
    public static void Run()
    {
        MethodInfo method = typeof(Author).GetMethod(nameof(Author.GetName))!;
        bool exists = method.IsDefined(
            typeof(ObsoleteAttribute),
            inherit: false);
        Console.WriteLine(exists);
    }
}
