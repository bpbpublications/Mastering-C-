
Console.WriteLine("=== Listing 1 ===");
try
{
    Listing01.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Listing 1 failed: {ex.Message}");
}

Console.WriteLine("=== Listing 2 ===");
try
{
    Listing02.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Listing 2 failed: {ex.Message}");
}

Console.WriteLine("=== Listing 3 ===");
try
{
    Listing03.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Listing 3 failed: {ex.Message}");
}

// ---- Code Listing 1 ----
public static class Listing01
{
    public static void Run()
    {
        Func<int, int, int> add = (a, b) => a + b;
        int result = add(5, 4);
        Console.WriteLine($"add(5, 4) = {result}");
    }
}

// ---- Code Listing 2 ----
public static class Listing02
{
    public static void Run()
    {
        Action<string> message = text => Console.WriteLine($"Hello, {text}!");
        message("Joydip");
    }
}

// ---- Code Listing 3 ----
public static class Listing03
{
    public static void Run()
    {
        Predicate<int> isOdd = num => num % 2 != 0;
        bool result = isOdd(5);
        Console.WriteLine($"isOdd(5) = {result}");
    }
}
