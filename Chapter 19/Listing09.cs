using System;

public static class Listing09
{
    public static void Run()
    {
        var numbers = new[] { 10, 20, 30, 40, 50 };
        bool found = Contains(numbers, 20);
        Console.WriteLine(found);
    }

    private static bool Contains<T>(ReadOnlySpan<T> span, T value)
        where T : IEquatable<T>
    {
        foreach (var x in span)
        {
            if (x.Equals(value))
                return true;
        }
        return false;
    }
}
