// ---- Code Listing 3 ----
public static class Listing03
{
    public static void Run()
    {
        var input = "steve.smith@example.com";
        var match = Regex.Match(input, @"^(.+)@(.+)$");
        if (match.Success)
        {
            Console.WriteLine(match.Groups[1].Value);
            Console.WriteLine(match.Groups[2].Value);
        }
    }
}
