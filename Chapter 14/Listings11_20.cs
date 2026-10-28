using System;
using System.Threading;

namespace Chapter14.Listings;

// ---- Code Listing 11 ----
public static class Listing11
{
    public static void Run()
    {
        Thread t = new Thread(new ThreadStart(SomeThreadMethod));
        t.Start();
        Console.WriteLine("The thread's state is: " + t.ThreadState.ToString());
        t.Join();
    }

    static void SomeThreadMethod()
    {
        Thread.Sleep(50);
    }
}

// ---- Code Listing 12 ----
public static class Listing12
{
    public static void Run()
    {
        Console.WriteLine("(Listing 12 is illustrative prose about Thread.Suspend()/Resume(), which are obsolete and unsupported on modern .NET; see comments in source.)");
    }
}

// ---- Code Listing 13 ----
public static class Listing13
{
    public static void Run()
    {
        Thread t = new Thread(() => Display("Hello World!"));
        t.Start();
        t.Join();
    }

    static void Display(string message)
    {
        Console.WriteLine(message);
    }
}

// ---- Code Listing 14 ----
public static class Listing14
{
    public static void Run()
    {
        Thread t = new Thread(Display);
        t.Start("Hello World!");
        t.Join();
    }

    static void Display(object? message)
    {
        Console.WriteLine(message);
    }
}

// ---- Code Listing 15 ----
public static class Listing15
{
    public static void Run()
    {
        Thread.CurrentThread.Name ??= "Main Thread";
        Console.WriteLine("The name of the currently executing thread is: " + Thread.CurrentThread.Name);

        Thread t = new Thread(Display);
        t.Name = "Worker Thread";
        t.Start();
        t.Join();
    }

    static void Display()
    {
        Console.WriteLine("The name of the currently executing thread is: " + Thread.CurrentThread.Name);
    }
}

// ---- Code Listing 16 ----
public static class Listing16
{
    public static void Run()
    {
        Thread.Sleep(100);
        Console.WriteLine("Slept for 100ms.");
    }
}

// ---- Code Listing 17 ----
public static class Listing17
{
    public static void Run()
    {
        Thread t = new Thread(() => Thread.Sleep(Timeout.InfiniteTimeSpan));
        t.IsBackground = true;
        t.Start();
        Console.WriteLine("Started a background thread that sleeps forever (Thread.Sleep(Timeout.InfiniteTimeSpan)); it will not block this demo or process exit.");
    }
}

// ---- Code Listings 18-19 ----
public static class Group18to19
{
    public static void Run()
    {
        MyThreadClass obj = new MyThreadClass();
        Thread threadObjA = new Thread(new ThreadStart(obj.MyThreadMethodA));
        Thread threadObjB = new Thread(new ThreadStart(obj.MyThreadMethodB));
        threadObjA.Start();
        threadObjA.Join();
        threadObjB.Start();
        threadObjB.Join();
    }

    public class MyThreadClass
    {
        public void MyThreadMethodA()
        {
            Console.WriteLine("Inside MyThreadMethodA..");

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(x);
                Thread.Sleep(20);
            }
        }

        public void MyThreadMethodB()
        {
            Console.WriteLine("Inside MyThreadMethodB..");

            for (int x = 10; x > 0; x--)
            {
                Console.WriteLine(x);
                Thread.Sleep(20);
            }
        }
    }
}

// ---- Code Listing 20 ----
public static class Listing20
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
