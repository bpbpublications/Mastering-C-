using System.Collections.Concurrent;

namespace Chapter7;

// ---- Code Listing 43 ----
public static class Listing43
{
    public static void Run()
    {
        ConcurrentStack<int> concurrentStack = new ConcurrentStack<int>();
        for (int i = 0; i < 10; i++)
            concurrentStack.Push(i);
    }
}

// ---- Code Listing 44 ----
public static class Listing44
{
    public static void Run()
    {
        ConcurrentStack<int> concurrentStack = new ConcurrentStack<int>();
        for (int i = 0; i < 10; i++)
            concurrentStack.Push(i);

        int result;
        while (concurrentStack.TryPop(out result))
        {
            Console.WriteLine(result);
        }
    }
}

// ---- Code Listing 45 ----
public static class Listing45
{
    public static void Run()
    {
        ConcurrentStack<int> concurrentStack = new ConcurrentStack<int>();
        for (int i = 0; i < 10; i++)
            concurrentStack.Push(i);

        if (concurrentStack.IsEmpty)
        {
            Console.WriteLine("The stack is empty.");
        }
        else
        {
            int result;
            while (concurrentStack.TryPop(out result))
            {
                Console.WriteLine(result);
            }
        }
    }
}
