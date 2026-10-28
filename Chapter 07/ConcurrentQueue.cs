using System.Collections.Concurrent;

namespace Chapter7;

// ---- Code Listing 46 ----
public static class Listing46
{
    public static void Run()
    {
        ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();
        for (int i = 0; i < 10; i++)
            concurrentQueue.Enqueue(i);
    }
}

// ---- Code Listing 47 ----
public static class Listing47
{
    public static void Run()
    {
        ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();
        for (int i = 0; i < 10; i++)
            concurrentQueue.Enqueue(i);

        int number;
        while (concurrentQueue.TryDequeue(out number))
        {
            Console.WriteLine(number);
        }
    }
}

// ---- Code Listing 48 ----
public static class Listing48
{
    public static void Run()
    {
        ConcurrentQueue<int> concurrentQueue = new
        ConcurrentQueue<int>();

        for (int i = 0; i < 10; i++)
            concurrentQueue.Enqueue(i);
        int number;
        while (concurrentQueue.TryDequeue(out number))
        {
            Console.WriteLine(number);
        }
    }
}
