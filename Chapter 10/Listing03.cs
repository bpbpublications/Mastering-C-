namespace Chapter10;

// ---- Code Listing 03 ----
public static class Listing03
{
    public static void Run()
    {
        using BPBEntities context = new BPBEntities();

        var authors = from a in context.Authors
                       where a.Age > 50
                       orderby a.FirstName
                       select a;

        foreach (var a in authors)
        {
            Console.WriteLine($"{a.FirstName} {a.LastName} (Age: {a.Age})");
        }
    }
}
