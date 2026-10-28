// ---- Code Listing 4 ----
using System.Runtime.InteropServices;

namespace Appendix;

public static partial class Listing04
{
    [LibraryImport("msvcrt.dll", StringMarshalling = StringMarshalling.Utf8)]
    private static partial int printf(string format);

    public static unsafe void Run()
    {
        try
        {
            printf("Hello World ...\n");
        }
        catch (DllNotFoundException)
        {
            Console.WriteLine("printf() from msvcrt.dll is unavailable on this platform (Windows-only); this is expected here.");
        }
    }
}
