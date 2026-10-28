using System;

public static class Listing07
{
    public static void Run()
    {
        var data = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        Memory<byte> memory = data;
        Memory<byte> firstHalf = memory.Slice(0, 4);
        Memory<byte> secondHalf = memory.Slice(4, 4);
        firstHalf.Span[0] = 100;
        secondHalf.Span[0] = 200;
        Console.WriteLine(string.Join(",", memory.Span.ToArray()));
    }
}
