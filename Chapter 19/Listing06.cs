using System;
using System.Buffers;

public static class Listing06
{
    public static void Run()
    {
        var pool = ArrayPool<byte>.Shared;
        byte[] rented = pool.Rent(1024);
        try
        {
            Memory<byte> memory = rented;
            var span = memory.Span;
            span.Fill(100);
            Console.WriteLine($"First byte: {span[0]}");
        }
        finally
        {
            pool.Return(rented);
        }
    }
}
