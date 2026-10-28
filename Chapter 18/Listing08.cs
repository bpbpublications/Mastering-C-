// ---- Code Listing 8 ----
public static class Listing08
{
    public static void Run()
    {
        var calculator = new Calculator();
        var total = calculator.Add(10, 20);
        Console.WriteLine($"Total = {total}");
    }
}
