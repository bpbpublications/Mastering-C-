// ---- Code Listing 7 ----
using System.Collections.Generic;
using System.Linq;

namespace Appendix;

public static class Listing07
{
    public static void Run()
    {
        IEnumerable<string> strings = new List<string> { "Hello World!" };
        IEnumerable<object> objects = strings;
        Console.WriteLine("Covariance OK, first element: " + objects.First());
    }
}
