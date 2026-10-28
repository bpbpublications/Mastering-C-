namespace Chapter10;

// ---- Code Listing 04 ----
public static class Listing04
{
    public static void Run()
    {
        using BPBEntities context = new BPBEntities();

        var authors = context.Authors
                              .Where(a => a.Age > 50)
                              .OrderBy(a => a.FirstName);

        foreach (var a in authors)
        {
            Console.WriteLine($"{a.FirstName} {a.LastName} (Age: {a.Age})");
        }
    }
}
