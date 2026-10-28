// ---- Code Listing 6 ----
public static class Listing06
{
    public static void Run()
    {
        string input = "Hello World! 2026";
        string pattern = @"\d{4}";
        bool doesInputContainYear = Regex.IsMatch(input, pattern);
        Console.WriteLine($"Contains year: {doesInputContainYear}");
    }
}
