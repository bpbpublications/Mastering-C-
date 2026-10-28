namespace Chapter8;

// ---- Code Listing 20 ----
public static class Listing20
{
    public static void Run()
    {
        Action action = () => Console.WriteLine("Action executed via Task.Run.");
        Task.Run(action).Wait();
    }
}
