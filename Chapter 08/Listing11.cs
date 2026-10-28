namespace Chapter8;

// ---- Code Listing 11 ----
public static class Listing11
{
    public static void Run()
    {
        var results = from a in SampleData.Authors.AsParallel().WithDegreeOfParallelism(3)
                       where a.FirstName.StartsWith("J")
                       select a;

        foreach (var r in results)
        {
            Console.WriteLine(r.FirstName + "\t" + r.LastName);
        }
    }
}
