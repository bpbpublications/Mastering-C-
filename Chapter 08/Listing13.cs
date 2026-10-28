namespace Chapter8;

// ---- Code Listing 13 ----
public static class Listing13
{
    public static void Run()
    {
        int sum = ParallelEnumerable.Repeat(1, 100).Select(n => n).Sum();
        Console.WriteLine($"Sum: {sum}");
    }
}
