namespace Chapter8;

// ---- Code Listing 26 ----
public static class Listing26
{
    public static void Run()
    {
        Task<int> output1 = Task.Run(() => SomeMethod());
        Task<int> output2 = Task.Run(() => SomeMethod());
        Task<int> output3 = Task.Run(() => SomeMethod());
        Task<int> output4 = Task.Run(() => SomeMethod());
        Task<int> output5 = Task.Run(() => SomeMethod());

        var taskList = new List<Task>();
        taskList.Add(output1);
        taskList.Add(output2);
        taskList.Add(output3);
        taskList.Add(output4);
        taskList.Add(output5);

        Task.WhenAll(taskList).ContinueWith(t =>
        {
            Console.WriteLine("All tasks have been completed");
        }).Wait();
    }

    private static int SomeMethod()
    {
        Thread.Sleep(1000);
        return Thread.CurrentThread.ManagedThreadId;
    }
}
