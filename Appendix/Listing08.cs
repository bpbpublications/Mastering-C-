// ---- Code Listing 8 ----
namespace Appendix;

public static class Listing08
{
    public static void Run()
    {
        Action<object> actionObject = obj => Console.WriteLine("Contravariance OK, received: " + obj);
        Action<string> str = actionObject;
        str("Hello from a string-typed delegate backed by an object-typed one");
    }
}
