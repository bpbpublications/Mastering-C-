// ---- Code Listing 9 ----
using System.Reflection;

public static class Listing09
{
    public static void Run()
    {
        var calculator = new Calculator();
        var method = typeof(Calculator).GetMethod("Add")!;
        var result = method.Invoke(calculator, new object[] { 10, 20 });
        Console.WriteLine($"Result = {result}");
    }
}
