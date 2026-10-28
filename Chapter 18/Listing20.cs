// ---- Code Listing 20 ----
using System.Reflection;

public class Sample
{
    public void Run()
    {
        Console.WriteLine("Running...");
    }
}

public static class Listing20
{
    public static void Run()
    {
        Type type = typeof(Sample);
        object instance = Activator.CreateInstance(type)!;
        MethodInfo? myMethod = type.GetMethod("Run");
        myMethod?.Invoke(instance, null);
    }
}
