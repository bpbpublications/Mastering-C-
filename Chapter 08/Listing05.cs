namespace Chapter8;

// ---- Code Listing 5 ----
public static class Listing05
{
    public static void Run()
    {
        var data = from a in SampleData.Authors.AsParallel() where a.FirstName.StartsWith("J") select a;
        foreach (var a in data)
        {
            Console.WriteLine(a.FirstName + "\t" + a.LastName);
        }
    }
}
