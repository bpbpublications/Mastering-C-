// ---- Code Listing 17 ----
public static class Listing17
{
    public static void Run()
    {
        HashSet<int> hashSet = new HashSet<int>();

        hashSet.Add(1);
        hashSet.Add(2);
        hashSet.Add(3);
        hashSet.Add(3);

        Console.WriteLine("HashSet elements:");
        foreach (int i in hashSet)
        {
            Console.WriteLine(i);
        }

        if (hashSet.Contains(2))
        {
            Console.WriteLine("Element 2 exists in HashSet.");
        }

        hashSet.Remove(3);

        Console.WriteLine("After removing 3:");
        foreach (int i in hashSet)
        {
            Console.WriteLine(i);
        }
    }
}
