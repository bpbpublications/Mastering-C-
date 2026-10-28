using System;
using System.Threading;

namespace Chapter14.Listings;

// ---- Code Listings 1-3 ----
public static class Group01to03
{
    public static void Run()
    {
        Thread t = new Thread(new ThreadStart(SomeThreadMethod));
        t.Start();
        t.Join();
    }

    static void SomeThreadMethod()
    {
        Console.WriteLine("Hello World!");
    }
}

// ---- Code Listing 4 ----
public static class Listing04
{
    public static void Run()
    {
        Thread t = new Thread(SomeThreadMethod);
        t.Start();
        t.Join();
    }

    static void SomeThreadMethod()
    {
        Console.WriteLine("Hello World!");
    }
}

// ---- Code Listing 5 ----
public static class Listing05
{
    public static void Run()
    {
        Thread t1 = new Thread(Display);
        t1.Start();

        Thread t2 = new Thread(Display);
        t2.Start();

        t1.Join();
        t2.Join();
    }

    static void Display()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(100);
        }
    }
}

// ---- Code Listing 6 ----
public static class Listing06
{
    public static void Run()
    {
        Thread thread = new Thread(new ThreadStart(SomeThreadMethod));
        thread.Start();
        thread.IsBackground = true;
        Console.WriteLine("Thread status: " + thread.IsBackground.ToString());
        thread.Join();
    }

    static void SomeThreadMethod()
    {
        Console.WriteLine("Hello from Listing06 thread.");
    }
}

// ---- Code Listing 7 ----
public static class Listing07
{
    public static void Run()
    {
        Thread t = new Thread(Display);
        t.Name = "Worker Thread";

        if (t.IsBackground)
        {
            Console.WriteLine("This is a background thread.");
        }
        else
        {
            Console.WriteLine("This is a foreground thread.");
        }

        t.Start();
        t.Join();
    }

    static void Display()
    {
        Thread.Sleep(200);
    }
}

// ---- Code Listing 8 ----
public static class Listing08
{
    public static void Run()
    {
        try
        {
            Thread t = new Thread(Display);
            t.Start();
            t.Join();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught in caller (should not normally happen): " + ex.Message);
        }
    }

    static void Display()
    {
        try
        {
            throw new Exception("Exception thrown from thread method.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("[Listing 8] Exception occurred on worker thread and was NOT caught by the caller's try/catch: " + ex.Message);
        }
    }
}

// ---- Code Listing 9 ----
public static class Listing09
{
    public static void Run()
    {
        Thread t = new Thread(Display);
        t.Start();
        t.Join();
    }

    static void Display()
    {
        try
        {
            throw new Exception("Exception thrown from thread method.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

// ---- Code Listing 10 ----
public static class Listing10
{
    public static void Run()
    {
        Console.WriteLine("System.Threading.ThreadState values:");
        foreach (var value in Enum.GetValues<ThreadState>())
        {
            Console.WriteLine("  " + value);
        }
    }
}
