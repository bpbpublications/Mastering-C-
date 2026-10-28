// ---- Code Listing 12 ----
namespace Appendix;

public static class Listing12
{
    public static void Run()
    {
        var syncLock = new System.Threading.Lock();
        using (syncLock.EnterScope())
        {
            Console.WriteLine("Inside the System.Threading.Lock critical section.");
        }
    }
}
