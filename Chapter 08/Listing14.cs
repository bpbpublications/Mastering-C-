namespace Chapter8;

// ---- Code Listing 14 ----
public static class Listing14
{
    public static void Run()
    {
        var results = from e in SampleData.Employees.AsParallel() where e.FirstName.StartsWith("J") select e;
        foreach (var r in results)
        {
            Console.WriteLine(r.FirstName + "\t" + r.LastName);
        }
    }
}
