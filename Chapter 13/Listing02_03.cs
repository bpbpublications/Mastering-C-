// ---- Code Listing 2 ----
public static class Listing02
{
    public static void Run()
    {
        Console.WriteLine("Listing 2 illustrates a compile-time type-safety error");
        Console.WriteLine("(List<int>.Add(\"text\") does not compile) - kept as a comment only.");
    }
}

// ---- Code Listing 3 ----
public static class Listing03
{
    public static void Run()
    {
        List<int> integers = new List<int>();
        integers.Add(10);
        int result = integers[0] + 100;
        Console.WriteLine($"result = {result}");
    }
}
