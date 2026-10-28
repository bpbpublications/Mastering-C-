// ---- Code Listing 4 ----
public static class Listing04
{
    public static void Run()
    {
        var input = "1000, 2000, 3000";
        foreach (Match m in Regex.Matches(input, @"\d+(?=,)"))
            Console.WriteLine(m.Value);
    }
}
