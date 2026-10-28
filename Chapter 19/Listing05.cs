using System;

public static class Listing05
{
    public static void Run()
    {
        string input = "abcdef";
        ReadOnlySpan<char> span = input.AsSpan();
        ReadOnlySpan<char> part = span.Slice(1, 3);
        foreach (var c in part)
        {
            Console.Write(c);
        }
        Console.WriteLine();
    }
}
