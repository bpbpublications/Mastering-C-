namespace Chapter6;

// ---- Code Listing 5 ----
public abstract class Person
{
    public abstract int Id { get; set; }
    public abstract string FirstName { get; set; }
    public abstract string LastName { get; set; }
}

public static class Listing05
{
    public static void Run()
    {
        Console.WriteLine("Person is an abstract class declaring Id, FirstName, and LastName as abstract properties.");
    }
}
