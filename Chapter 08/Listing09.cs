namespace Chapter8;

// ---- Code Listing 9 ----
public static class Listing09
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
