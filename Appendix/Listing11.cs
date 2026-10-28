// ---- Code Listing 11 ----
namespace Appendix;

public static class Listing11
{
    public static ref readonly int FindMax(ref readonly Span<int> span)
    {
        int maxIndex = 0;
        for (int i = 1; i < span.Length; i++)
        {
            if (span[i] > span[maxIndex])
            {
                maxIndex = i;
            }
        }
        return ref span[maxIndex];
    }

    public static void Run()
    {
        Span<int> values = stackalloc int[] { 3, 7, 2, 9, 4 };
        ref readonly int max = ref FindMax(ref values);
        Console.WriteLine("Max value found via ref readonly parameter: " + max);
    }
}
