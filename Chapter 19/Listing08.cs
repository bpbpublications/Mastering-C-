using System;
using System.Threading.Tasks;

public static class Listing08
{
    public static async Task RunAsync()
    {
        var numbers = new int[] { 1, 2, 3, 4, 5 };
        Memory<int> memory = numbers;
        await ProcessAsync(memory);
        Console.WriteLine(string.Join(", ", numbers));
    }

    private static async Task ProcessAsync(Memory<int> memory)
    {
        var span = memory.Span;
        for (int i = 0; i < span.Length; i++)
        {
            span[i] *= 2;
        }
        await Task.Delay(100);
    }
}
