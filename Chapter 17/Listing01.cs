// ---- Code Listing 1 ----

public class Test
{
    [Obsolete("This method is deprecated. Use the method Display(string) instead.", false)]
    internal void Display()
    {
    }

    internal void Display(string s)
    {
    }
}

public static class Listing01
{
    public static void Run()
    {
        Test test = new Test();
        test.Display();
    }
}
