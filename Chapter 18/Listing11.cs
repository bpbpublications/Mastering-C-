// ---- Code Listing 11 ----
using System.Reflection;

public class OrderProcessor
{
    public decimal Process(decimal amount) => amount * 1.1m;
}

public static class Listing11
{
    public static void Run()
    {
        Type type = typeof(OrderProcessor);
        object instance = Activator.CreateInstance(type)!;

        MethodInfo? method = type.GetMethod("Process");

        if (method != null)
        {
            ParameterInfo[] parameterArray = method.GetParameters();
            if (parameterArray.Length == 1 && parameterArray[0].ParameterType == typeof(decimal))
            {
                decimal result = (decimal)method.Invoke(instance, new object[] { 100m })!;
                Console.WriteLine(result);
            }
        }
    }
}
