// ---- Code Listing 1 ----
public static class Listing01
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

    private static void Display<G>(G[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Console.WriteLine(array[i]);
    }
}
