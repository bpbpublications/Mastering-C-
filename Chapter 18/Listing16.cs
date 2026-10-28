// ---- Code Listing 16 ----
public static class ReflectionHelper
{
    public static object? GetPropertyValue(object obj, string propertyName)
    {
        var prop = obj.GetType().GetProperty(propertyName);
        return prop?.GetValue(obj);
    }
}

public class User
{
    public string Email { get; set; } = "user@example.com";
}

public static class Listing16
{
    public static void Run()
    {
        var user = new User();
        Console.WriteLine(ReflectionHelper.GetPropertyValue(user, "Email"));
    }
}
