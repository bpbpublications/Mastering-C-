namespace Chapter8;

// ---- Code Listing 10 ----
public static class Listing10
{
    public static void Run()
    {
        var results = from a in SampleData.Authors.AsParallel().WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                       where a.FirstName.StartsWith("J")
                       select a;

        foreach (var r in results)
        {
            Console.WriteLine(r.FirstName + "\t" + r.LastName);
        }
    }
}
