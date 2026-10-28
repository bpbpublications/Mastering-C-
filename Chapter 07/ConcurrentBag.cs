using System.Collections.Concurrent;

namespace Chapter7;

// ---- Code Listing 34 ----
public static class Listing34
{
    public static void Run()
    {
        ConcurrentBag<int> bag = new ConcurrentBag<int>();
    }
}

// ---- Code Listing 35 ----
public static class Listing35
{
    public static void Run()
    {
        ConcurrentBag<int> concurrentBag = new ConcurrentBag<int>();
        concurrentBag.Add(1);
        concurrentBag.Add(2);
        concurrentBag.Add(3);
        concurrentBag.Add(4);
        concurrentBag.Add(5);
    }
}

// ---- Code Listing 36 ----
public static class Listing36
{
    public static void Run()
    {
        List<int> integers = new List<int>();
        integers.Add(1);
        integers.Add(2);
        integers.Add(3);
        integers.Add(4);
        integers.Add(5);
        ConcurrentBag<int> concurrentBag = new ConcurrentBag<int>(integers);
    }
}

// ---- Code Listing 37 ----
public static class Listing37
{
    public static void Run()
    {
        List<int> integers = new List<int> { 1, 2, 3, 4, 5 };
        ConcurrentBag<int> concurrentBag = new ConcurrentBag<int>(integers);
        int numberOfItems = concurrentBag.Count;
        Console.WriteLine(numberOfItems);
    }
}

// ---- Code Listing 38 ----
public static class Listing38
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
        Console.ReadKey();
    }
}

// ---- Code Listing 39 ----
public static class Listing39
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
                $"before TryTake() has been called is: {count}", count);

        if (concurrentBag.TryTake(out item))
        {
            count = concurrentBag.Count;
            Console.WriteLine($"The number of items remaining in the collection " +
                $"after TryTake() has been called is: { count}", count);
        }
        Console.ReadKey();
    }
}
