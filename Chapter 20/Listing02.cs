// ---- Code Listing 2 ----
public static class Listing02
{
    public static void Run()
    {
        string input = "Order 100 shipped, Order 205 shipped, Order 999 pending";
        string pattern = @"\d+";

        Match firstMatch = Regex.Match(input, pattern);
        Console.WriteLine($"First match: {firstMatch.Value}");

        MatchCollection allMatches = Regex.Matches(input, pattern);
        foreach (Match m in allMatches)
        {
            Console.WriteLine($"Match: {m.Value}");
        }

        string replaced = Regex.Replace(input, pattern, "###");
        Console.WriteLine(replaced);
    }
}
