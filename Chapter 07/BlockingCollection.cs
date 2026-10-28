using System.Collections.Concurrent;

namespace Chapter7;

// ---- Code Listing 27 ----
public static class Listing27
{
    public static void Run()
    {
        BlockingCollection<int> data = new BlockingCollection<int>(boundedCapacity: 5);
    }
}

// ---- Code Listing 28 ----
public static class Listing28
{
    public static void Run()
    {
        BlockingCollection<int> blockingCollection = new BlockingCollection<int>(boundedCapacity: 3);
        blockingCollection.Add(1);
        blockingCollection.Add(2);
        blockingCollection.Add(3);
        blockingCollection.Add(4);
        blockingCollection.Add(5);
    }
}

// ---- Code Listing 29 ----
public static class Listing29
{
    public static void Run()
    {
        BlockingCollection<int> blockingCollection = new BlockingCollection<int>(boundedCapacity: 5);
        blockingCollection.Add(1);
        blockingCollection.Add(2);
        blockingCollection.Add(3);
        blockingCollection.Add(4);
        if (blockingCollection.TryAdd(5, TimeSpan.FromSeconds(1)))
        {
            Console.WriteLine("Item has been added to the collection.");
        }
        else
        {
            Console.WriteLine("Item hasn't been added to the collection.");
        }
    }
}

// ---- Code Listing 30 ----

// ---- Code Listing 31 ----

// ---- Code Listing 32 ----
public static class Listing32
{
    public static void Run()
    {
        BlockingCollection<int> blockingCollection = new BlockingCollection<int>(boundedCapacity: 3);
        blockingCollection.Add(1);
        blockingCollection.Add(2);
        blockingCollection.Add(3);
        int item = blockingCollection.Take();
        Console.WriteLine(item);
    }
}

// ---- Code Listing 33 ----
public static class Listing33
{
    public static void Run()
    {
        BlockingCollection<int> blockingCollection = new BlockingCollection<int>(boundedCapacity: 3);
        blockingCollection.Add(1);
        blockingCollection.Add(2);
        blockingCollection.Add(3);

        int item = blockingCollection.Take();
        if (blockingCollection.TryTake(out item, TimeSpan.FromSeconds(1)))
        {
            Console.WriteLine(item);
        }
        else
        {
            Console.WriteLine("Item couldn't be removed from the collection");
        }
    }
}
