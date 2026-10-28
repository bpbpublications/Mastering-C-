namespace Chapter7;

// ---- Code Listing 7 ----
public static class Listing07
{
    public static void Run()
    {
        Console.WriteLine("Listing 7 is illustrative only: adding a string to a " +
            "List<int> does not compile (CS1503) - see comments in source.");
    }
}

// ---- Code Listing 8 ----
public static class Listing08
{
    public static void Run()
    {
        List<int> integers = new List<int>();
        integers.Add(10);
        int result = integers[0] + 100;
        Console.WriteLine(result);
    }
}

// ---- Code Listing 9 ----
public class GenericRepositoryDemo<T>
{
    public void Add(T item)
    {
    }
    public T GetById(int id)
    {
        throw new NotImplementedException();
    }
}

// ---- Code Listing 10 ----
public static class Listing10
{
    public static void Display<T>(T data)
    {
        Console.WriteLine($"Displaying data: {data}");
    }
}

// ---- Code Listing 11 ----
public delegate void CustomAction<T>(T item);

// ---- Code Listing 12 ----
public static class Listing12
{
    public static void Run()
    {
        CustomAction<string> displayText = Listing10.Display;
        displayText("This is a text message.");

        CustomAction<int> displayInteger = Listing10.Display;
        displayInteger(125);
    }
}

// ---- Code Listing 13 ----
public static class Listing13
{
    public static void Run()
    {
        CustomAction<string> displayText = Display;
        displayText("This is a text message.");
        CustomAction<int> displayInteger = Display;
        displayInteger(125);
        Console.Read();
    }

    static void Display<T>(T data)
    {
        Console.WriteLine($"Displaying data: {data}");
    }
}
