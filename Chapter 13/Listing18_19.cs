using System.Collections.Concurrent;

// ---- Code Listing 18 ----
public static class Listing18
{
    public static void Run()
    {
        ConcurrentBag<int> concurrentBag = new ConcurrentBag<int>();
        concurrentBag.Add(1);
        concurrentBag.Add(2);
        concurrentBag.Add(3);
        concurrentBag.Add(4);
        concurrentBag.Add(5);

        int item;
        if (concurrentBag.TryPeek(out item))
        {
            Console.WriteLine(item);
        }
    }
}

// ---- Code Listing 19 ----
public static class Listing19
{
    public static void Run()
    {
        ConcurrentBag<int> concurrentBag = new ConcurrentBag<int>();
        concurrentBag.Add(1);
        concurrentBag.Add(2);
        concurrentBag.Add(3);
        concurrentBag.Add(4);
        concurrentBag.Add(5);

        int item;
        int count = concurrentBag.Count;

        Console.WriteLine($"The number of items present in the collection " +
                $"before TryTake() has been called is: {count}");

        if (concurrentBag.TryTake(out item))
        {
            count = concurrentBag.Count;
            Console.WriteLine($"The number of items remaining in the collection " +
                $"after TryTake() has been called is: {count}");
        }
    }
}
