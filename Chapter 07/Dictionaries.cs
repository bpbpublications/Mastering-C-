namespace Chapter7;

// ---- Code Listing 22 ----
public static class Listing22
{
    public static void Run()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "A");
        dictionary.Add(2, "B");
        dictionary.Add(3, "C");
    }
}

// ---- Code Listing 23 ----
public static class Listing23
{
    public static void Run()
    {
        IDictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(new KeyValuePair<int, string>(1, "A"));
        dictionary.Add(new KeyValuePair<int, string>(2, "B"));
        dictionary.Add(new KeyValuePair<int, string>(3, "C"));
    }
}

// ---- Code Listing 24 ----
public static class Listing24
{
    public static void Run()
    {
        IDictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(new KeyValuePair<int, string>(1, "A"));
        dictionary.Add(new KeyValuePair<int, string>(2, "B"));
        dictionary.Add(new KeyValuePair<int, string>(3, "C"));

        foreach (KeyValuePair<int, string> item in dictionary)
        {
            Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
        }
    }
}

// ---- Code Listing 25 ----
public static class Listing25
{
    public static void Run()
    {
        HashSet<int> hashSet = new HashSet<int>();
        for (int i = 0; i < 10; i++)
        {
            hashSet.Add(i);
        }

        foreach (int i in hashSet)
        {
            Console.WriteLine(i);
        }
    }
}
