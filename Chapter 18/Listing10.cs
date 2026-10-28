// ---- Code Listing 10 ----
using System.Reflection;

public class SimplePerson
{
    public string Name { get; set; } = "";
}

public static class Listing10
{
    public static void Run()
    {
        Type type = typeof(SimplePerson);
        PropertyInfo propertyInfo = type.GetProperty(nameof(SimplePerson.Name))!;
        SimplePerson personInstance = Activator.CreateInstance<SimplePerson>();

        propertyInfo.SetValue(personInstance, "Joydip");
        Console.WriteLine(personInstance.Name);
    }
}
