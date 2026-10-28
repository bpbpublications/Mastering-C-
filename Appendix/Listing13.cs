// ---- Code Listing 13 ----
using System.Threading.Tasks;

namespace Appendix;

public static class Listing13
{
    public static async Task RunAsync()
    {
        await Task.Delay(100);
        Console.WriteLine("Async main has completed its execution successfully.");
    }

    private static async Task DoSomeWorkAsync()
    {
        await Task.Delay(50);
    }
}
