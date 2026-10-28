namespace Chapter8;

// ---- Code Listing 23 ----
public static class Listing23
{
    public static async Task RunAsync()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        Task<int> output = Task.Run(() => SomeMethod());
        Console.WriteLine(await output);
    }

    private static int SomeMethod()
    {
        Thread.Sleep(2000);
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        return 100;
    }
}
