namespace Chapter6;

// ---- Code Listing 9 ----
public class OverloadedIndexer
{
    private string[] message = new string[2];
    public string this[int flag]
    {
        get { return message[flag]; }
        set { message[flag] = value; }
    }

    public string this[bool flag]
    {
        get { return message[1]; }
        set { message[1] = value; }
    }
}

public static class Listing09
{
    public static void Run()
    {
        Console.WriteLine("OverloadedIndexer declares int and bool indexers (used in Listing 10).");
    }
}

// ---- Code Listing 10 ----
public static class Listing10
{
    public static void Run()
    {
        var overloadedIndexer = new OverloadedIndexer();
        overloadedIndexer[0] = "This is the first text message.";
        overloadedIndexer[true] = "This is the second text message";

        Console.WriteLine(overloadedIndexer[0] + "\n" + overloadedIndexer[true]);
    }
}
