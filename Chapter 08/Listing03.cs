namespace Chapter8;

// ---- Code Listing 3 ----
public static class Listing03
{
    public static void Run()
    {
        var data = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Parallel.ForEach(data, item =>
        {
            Console.WriteLine($"Processing {item}");
        });
    }
}
