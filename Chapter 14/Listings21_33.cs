using System;
using System.Threading;

namespace Chapter14.Listings;

// ---- Code Listing 21 ----
public static class Listing21
{
    public static void Run()
    {
        Thread threadObj = new Thread(() => Thread.Sleep(200));
        threadObj.Start();

        if (threadObj.IsAlive == true)
        {
            try
            {
                threadObj.Abort();
            }
            catch (PlatformNotSupportedException ex)
            {
                Console.WriteLine("Thread.Abort() is not supported on this platform: " + ex.Message);
            }
        }

        threadObj.Join();
    }
}

// ---- Code Listing 22 ----
public static class Listing22
{
    public static void Run()
    {
        Console.WriteLine("System.Threading.ThreadPriority values:");
        foreach (var value in Enum.GetValues<ThreadPriority>())
        {
            Console.WriteLine("  " + value);
        }
    }
}

// ---- Code Listing 23 ----
public static class Listing23
{
    public enum ThreadPriorityIllustration { Lowest, BelowNormal, Normal, AboveNormal, Highest }

    public static void Run()
    {
        Console.WriteLine("Illustrative enum (mirrors System.Threading.ThreadPriority): " +
            string.Join(", ", Enum.GetNames<ThreadPriorityIllustration>()));
    }
}

// ---- Code Listings 24-25 ----
public static class Group24to25
{
    public static void Run()
    {
        MyThreadClass obj = new MyThreadClass();
        Thread thread1 = new Thread(new ThreadStart(obj.MyThreadMethodA));
        Thread thread2 = new Thread(new ThreadStart(obj.MyThreadMethodB));
        thread2.Priority = ThreadPriority.Highest;
        thread1.Priority = ThreadPriority.Lowest;
        thread1.Start();
        thread2.Start();
        thread1.Join();
        thread2.Join();
    }

    public class MyThreadClass
    {
        public void MyThreadMethodA()
        {
            Console.WriteLine("Inside MyThreadMethodA..");
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine(x);
            }
        }

        public void MyThreadMethodB()
        {
            Console.WriteLine("Inside MyThreadMethodB..");
            for (int x = 5; x > 0; x--)
            {
                Console.WriteLine(x);
            }
        }
    }
}

// ---- Code Listing 26 ----
public static class Listing26
{
    public static void Run()
    {
        MyThreadClass obj = new MyThreadClass();
        Thread thread1 = new Thread(new ThreadStart(obj.MyThreadMethodA));
        Thread thread2 = new Thread(new ThreadStart(obj.MyThreadMethodB));
        thread2.Priority = ThreadPriority.Highest;
        thread1.Priority = ThreadPriority.Lowest;
        thread1.Start();
        thread2.Start();
        thread1.Join();
        thread2.Join();
    }

    public class MyThreadClass
    {
        public void MyThreadMethodA()
        {
            Console.WriteLine("Inside MyThreadMethodA..");
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine(x);
            }
        }

        public void MyThreadMethodB()
        {
            Console.WriteLine("Inside MyThreadMethodB..");
            for (int x = 5; x > 0; x--)
            {
                Console.WriteLine(x);
            }
        }
    }
}

// ---- Code Listing 27 ----
public static class Listing27
{
    public static void Run()
    {
        ThreadPool.SetMinThreads(25, 25);
        Console.WriteLine("Called ThreadPool.SetMinThreads(25, 25).");
    }
}

// ---- Code Listing 28 ----
public static class Listing28
{
    public static void Run()
    {
        int availableWorkerThreads = 0;
        int availableAsyncIOThreads = 0;
        ThreadPool.GetMinThreads(out availableWorkerThreads, out availableAsyncIOThreads);
        Console.WriteLine($"Min worker threads: {availableWorkerThreads}, min async I/O threads: {availableAsyncIOThreads}");
    }
}

// ---- Code Listing 29 ----
public class ThreadUnsafe
{
    static int i = 10, j = 1;

    static void Display()
    {
        if (j != 0)
            Console.WriteLine(i / j);
        j = 0;
    }

    public static void Run()
    {
        Display();
        Display();
    }
}

public static class Listing29
{
    public static void Run() => ThreadUnsafe.Run();
}

// ---- Code Listing 30 ----
public class ThreadSafe
{
    private static readonly object lockObj = new object();
    static int i = 10, j = 1;

    static void Display()
    {
        if (j != 0)
        {
            lock (lockObj)
            {
                Console.WriteLine(i / j);
                j = 0;
            }
        }
    }

    public static void Run()
    {
        Display();
        Display();
    }
}

public static class Listing30
{
    public static void Run() => ThreadSafe.Run();
}

// ---- Code Listing 31 ----
public class ThreadSafeMonitor
{
    private static readonly object lockObj = new object();
    static int i = 10, j = 1;

    static void Display()
    {
        if (j != 0)
        {
            Monitor.Enter(lockObj);
            try
            {
                Console.WriteLine(i / j);
                j = 0;
            }
            finally
            {
                Monitor.Exit(lockObj);
            }
        }
    }

    public static void Run()
    {
        Display();
        Display();
    }
}

public static class Listing31
{
    public static void Run() => ThreadSafeMonitor.Run();
}

// ---- Code Listings 32-33 ----
public static class Group32to33
{
    public static void Run()
    {
        {
            object resourceA = new object();
            object resourceB = new object();
            lock (resourceA)
            {
                lock (resourceB)
                {
                }
            }
            Console.WriteLine("Listing 32: acquired resourceA then resourceB (no contention, so no deadlock here).");
        }

        {
            object resourceA = new object();
            object resourceB = new object();
            lock (resourceB)
            {
                lock (resourceA)
                {
                }
            }
            Console.WriteLine("Listing 33: acquired resourceB then resourceA (no contention, so no deadlock here).");
        }
    }
}
