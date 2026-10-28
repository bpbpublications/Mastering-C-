namespace Chapter8;

// ---- Code Listing 4 ----
public static class Listing04
{
    public static void Run()
    {
        var data = from a in SampleData.Authors where a.FirstName.StartsWith("J") select a;
        foreach (var a in data)
        {
            Console.WriteLine(a.FirstName + "\t" + a.LastName);
        }
    }
}
