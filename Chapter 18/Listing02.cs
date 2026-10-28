// ---- Code Listing 2 ----
using System.Reflection;

public static class Listing02
{
    public static void Run()
    {
        Type type = typeof(List<string>);
        object instance = Activator.CreateInstance(type)!;
        MethodInfo addMethod = type.GetMethod("Add")!;
        addMethod.Invoke(instance, new object[] { "Some Value" });
        Console.WriteLine(((List<string>)instance)[0]);
    }
}
