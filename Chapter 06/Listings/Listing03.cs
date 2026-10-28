namespace Chapter6;

// ---- Code Listing 3 ----
public class Base
{
    protected int _id;
    public int Id
    {
        get
        {
            Console.WriteLine("Get accessor of the Base class called.");
            return _id;
        }
        set
        {
            _id = value;
            Console.WriteLine("Set accessor of the Base class called.");
        }
    }
}

public class Derived : Base
{
}

public static class Listing03
{
    public static void Run()
    {
        var derived = new Derived();
        derived.Id = 1;
        Console.WriteLine($"derived.Id = {derived.Id}");
    }
}
