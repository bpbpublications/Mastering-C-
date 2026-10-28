// ---- Code Listings 5-8 ----
public delegate void MyAction<T>(T item);

public static class DisplayHelper
{
    public static void Display<T>(T data)
    {
        Console.WriteLine($"Displaying data: {data}");
    }
}

// ---- Code Listing 5 ----
public static class Listing05
{
    public static void Run()
    {
        Console.WriteLine("Listing 5 defines the generic Display<T> method used by Listings 6-8.");
    }
}

// ---- Code Listing 6 ----
public static class Listing06
{
    public static void Run()
    {
        MyAction<string> displayText = DisplayHelper.Display;
        displayText("This is a text message.");
    }
}

// ---- Code Listing 7 ----
public static class Listing07
{
    public static void Run()
    {
        MyAction<int> displayInteger = DisplayHelper.Display;
        displayInteger(125);
    }
}

// ---- Code Listing 8 ----
public static class Listing08
{
    public static void Run()
    {
        MyAction<string> displayText = DisplayHelper.Display;
        displayText("This is a text message.");
        MyAction<int> displayInteger = DisplayHelper.Display;
        displayInteger(125);

    }
}
