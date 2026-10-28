using System;
using System.Buffers;

public static class Listing03
{
    public static void Run()
    {
        byte[] first = { 1, 2, 3 };
        byte[] second = { 4, 5, 6 };
        var startSegment = new BufferSegment(first);
        var endSegment = startSegment.Append(second);
        var sequence = new ReadOnlySequence<byte>(startSegment, 0, endSegment, second.Length);

        foreach (var segment in sequence)
        {
            Console.WriteLine(string.Join(",", segment.ToArray()));
        }
        Console.WriteLine($"Total length: {sequence.Length}");

    }
}
