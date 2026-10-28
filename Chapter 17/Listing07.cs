// ---- Code Listing 7 ----

public static class Listing07
{
    public static void Run()
    {
        Type personType = typeof(Person);
        AuthorAttribute? author = (AuthorAttribute?)Attribute.GetCustomAttribute(
            personType, typeof(AuthorAttribute));

        Console.WriteLine($"Author: {author?.Name}");
    }
}
