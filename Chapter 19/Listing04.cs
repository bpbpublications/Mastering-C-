using System;

public static class Listing04
{
    public static void Run()
    {
        var numbers = new[] { 1, 2, 3, 4, 5 };
        Span<int> span = numbers;
        var slice = span.Slice(start: 0, length: 3);
        for (int i = 0; i < slice.Length; i++)
        {
            slice[i] *= 10;
        }
        Console.WriteLine(string.Join(", ", numbers));
    }
}
