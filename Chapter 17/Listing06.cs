// ---- Code Listing 6 ----

[Author("Joydip Kanjilal")]
public class Person
{
    [Obsolete("Use GetFullName instead")]
    public string GetName() => "Joydip";
    public string GetFullName() => "Joydip Kanjila";
}

[AttributeUsage(AttributeTargets.Class)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }
    public AuthorAttribute(string name) => Name = name;
}

public static class Listing06
{
    public static void Run()
    {
        Person person = new Person();
        Console.WriteLine($"Full name: {person.GetFullName()}");
    }
}
