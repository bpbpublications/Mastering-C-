namespace Chapter8;

// ---- Code Listing 8 ----
public static class Listing08
{
    public static void Run()
    {
        var results = from e in SampleData.Employees
                       where e.FirstName.StartsWith("J")
                       select e;

        foreach (var r in results)
        {
            Console.WriteLine(r.FirstName + "\t" + r.LastName);
        }
    }
}
