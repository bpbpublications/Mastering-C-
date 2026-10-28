using System.Collections.Concurrent;

namespace Chapter7;

// ---- Code Listing 40 ----
public static class Listing40
{
    public static void Run()
    {
        ConcurrentDictionary<string, string> dictionary = new ConcurrentDictionary<string, string>();
        dictionary.TryAdd("1", "First");
        dictionary.TryAdd("2", "Second");
        dictionary.TryAdd("3", "Third");
        dictionary.TryAdd("4", "Fourth");
        dictionary.TryAdd("5", "Fifth");
    }
}

// ---- Code Listing 41 ----
public static class Listing41
{
    public static void Run()
    {
        string item;
        ConcurrentDictionary<string, string> dictionary =
            new ConcurrentDictionary<string, string>();
        dictionary.TryAdd("1", "First");
        dictionary.TryAdd("2", "Second");
        dictionary.TryAdd("3", "Third");
        dictionary.TryAdd("4", "Fourth");
        dictionary.TryAdd("5", "Fifth");

        if (dictionary.TryGetValue("1", out item))
        {
            Console.WriteLine(item);
        }
    }
}

// ---- Code Listing 42 ----
public static class Listing42
{
    public static void Run()
    {
        ConcurrentDictionary<string, string> dictionary =
            new ConcurrentDictionary<string, string>();
        dictionary.TryAdd("1", "First");
        dictionary.TryAdd("2", "Second");
        dictionary.TryAdd("3", "Third");
        dictionary.TryAdd("4", "Fourth");
        dictionary.TryAdd("5", "Fifth");
        foreach (var item in dictionary)
        {
            Console.WriteLine($"Key: {item.Key}, " +
                $"Value: {item.Value}", item.Key, item.Value);
        }
    }
}
