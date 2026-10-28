using System.Collections.Concurrent;

// ---- Code Listing 20 ----
public static class Listing20
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

        if (dictionary.TryGetValue("1", out item!))
        {
            Console.WriteLine(item);
        }
    }
}

// ---- Code Listing 21 ----
public static class Listing21
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
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }
}
