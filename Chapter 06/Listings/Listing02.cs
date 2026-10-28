namespace Chapter6;

// ---- Code Listing 2 ----

public class PropertyDemo
{
    int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
}

public static class Listing02
{
    public static void Run()
    {
        var demo = new PropertyDemo();
        demo.Id = 42;
        Console.WriteLine($"PropertyDemo.Id = {demo.Id}");
    }
}
