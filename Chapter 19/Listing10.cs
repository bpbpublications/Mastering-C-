using System;

public static class Listing10
{
    public static void Run()
    {
        string input = "  hello world  ";
        ReadOnlySpan<char> trimmed = input.AsSpan().Trim();
        bool isGreeting = trimmed.SequenceEqual("hello world".AsSpan());
        Console.WriteLine(isGreeting);
    }
}
