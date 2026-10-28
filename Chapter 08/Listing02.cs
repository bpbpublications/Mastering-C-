namespace Chapter8;

// ---- Code Listing 2 ----
public static class Listing02
{
    public static void Run()
    {
        Task.Run(() =>
        {
            Console.WriteLine("This Task is running in the background in a new thread.");
        }).Wait();
    }
}
