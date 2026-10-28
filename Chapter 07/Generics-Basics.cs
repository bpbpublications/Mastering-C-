namespace Chapter7;

// ---- Code Listing 1 ----
public class SomeClass<T>
{
    public void Display()
    {
    }
}

// ---- Code Listing 2 ----
public static class Listing02
{
    public static void Run()
    {
        SomeClass<int> someObject = new SomeClass<int>();
    }
}

// ---- Code Listing 3 ----
public static class Listing03
{
    public static void Run()
    {
        int[] integerArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    }
}

// ---- Code Listing 4 ----
public static class Listing04
{
    public static void Display<G>(G[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Console.WriteLine(array[i]);
    }
}

// ---- Code Listing 5 ----
public static class Listing05
{
    public static void Run()
    {
        char[] characterArray = { 'H', 'e', 'l', 'l', 'o', '!' };
        Console.WriteLine("\nDisplaying characters");
        Listing04.Display(characterArray);
    }
}

// ---- Code Listing 6 ----
public static class Listing06
{
    public static void Run()
    {
        int[] integerArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("Displaying integers");
        Display(integerArray);

        char[] characterArray = { 'H', 'e', 'l', 'l', 'o', '!' };
        Console.WriteLine("\nDisplaying characters");
        Display(characterArray);
    }

    static void Display<G>(G[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Console.WriteLine(array[i]);
    }
}
