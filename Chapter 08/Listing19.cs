namespace Chapter8;

// ---- Code Listing 19 ----
public static class Listing19
{
    public static void Run()
    {
        Action action = () => Console.WriteLine("Action executed via Task.Factory.StartNew.");
        Task.Factory.StartNew(action, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default).Wait();
    }
}
