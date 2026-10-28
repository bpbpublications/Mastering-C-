namespace Chapter8;

// ---- Code Listing 21 ----
public static class Listing21
{
    public static void Run()
    {
        var taskList = new List<Task> { Task.Delay(10), Task.Delay(20) };

        Task.WhenAll(taskList).ContinueWith(t =>
        {
            Console.WriteLine("All tasks in the list have completed.");
        }).Wait();
    }
}
