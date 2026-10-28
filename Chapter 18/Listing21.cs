// ---- Code Listing 21 ----
using System.Diagnostics;
using System.Reflection;

public static class Listing21
{
    public static void Run()
    {
        var calculator = new Calculator();
        var method = typeof(Calculator).GetMethod("Add")!;

        var sw = Stopwatch.StartNew();
        for (int i = 0; i < 10000; i++)
        {
            method.Invoke(calculator, new object[] { 1, 2 });
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
}
