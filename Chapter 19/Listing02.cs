using System;

public static class Listing02
{
    public static void Run()
    {
        Span<byte> buffer = stackalloc byte[10];
        for (int i = 0; i < buffer.Length; i++)
        {
            buffer[i] = (byte)i;
        }
        Span<byte> slice = buffer.Slice(3, 4);
        slice.Fill(255);
        Console.WriteLine(string.Join(",", buffer.ToArray()));
    }
}
