// ---- Code Listing 3 ----
namespace Appendix;

public static class Listing03
{
    public static unsafe void Run()
    {
        int x = 100;
        int* ptr = &x;
        *ptr = 200;
        Console.WriteLine(x);
    }
}
