// ---- Code Listing 1 ----
using System.Reflection;

public static class Listing01
{
    public static void Run()
    {
        Assembly assembly = Assembly.Load("MyLibrary");
        foreach (Type type in assembly.GetTypes())
        {
            Console.WriteLine(type.FullName);
        }
    }
}
