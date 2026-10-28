namespace Chapter8;

// ---- Code Listing 22 ----
public static class Listing22
{
    public static async Task RunAsync()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        Task<int> output = Task.Factory.StartNew(SomeMethod);
        Console.WriteLine(await output);
    }

    private static int SomeMethod()
    {
        Thread.Sleep(2000);
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        return 100;
    }
}
