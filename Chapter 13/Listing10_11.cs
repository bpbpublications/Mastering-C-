// ---- Code Listing 10 ----
public static class Listing10
{
    public static void Run()
    {
        Console.WriteLine("Listing 10 was just a 'using System;' directive in the original text (see note).");
    }
}

// ---- Code Listing 11 ----
public static class Listing11
{
    public static void Run()
    {
        GenericArrayList<int> genericArrayList = new GenericArrayList<int>(10);
        genericArrayList.Add(125);
        Console.WriteLine(genericArrayList[0].ToString());
    }
}
