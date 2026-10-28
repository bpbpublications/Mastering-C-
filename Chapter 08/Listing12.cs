namespace Chapter8;

// ---- Code Listing 12 ----
public static class Listing12
{
    public static void Run()
    {
        IEnumerable<int> numbers = ((ParallelQuery<int>)ParallelEnumerable.Range(1, 100))
            .Where(i => i % 2 == 0).Select(i => i);

        foreach (var n in numbers)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}
