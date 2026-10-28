using System;

public static class Listing11
{
    public static void Run()
    {
        ReadOnlySpan<char> line = "id,name,score".AsSpan();
        int commaIndex = line.IndexOf(',');
        ReadOnlySpan<char> firstField = line[..commaIndex];
        ReadOnlySpan<char> remainder = line[(commaIndex + 1)..];
        Console.WriteLine(firstField.ToString());
        Console.WriteLine(remainder.ToString());
    }
}
