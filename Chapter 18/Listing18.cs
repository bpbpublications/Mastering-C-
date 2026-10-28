// ---- Code Listing 18 (executable part) ----
public static class Listing18
{
    public static void Run()
    {
        IShape shape = new Circle { Radius = 2 };
        Console.WriteLine($"Area: {shape.Area()}");
    }
}
