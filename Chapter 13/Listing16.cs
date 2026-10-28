// ---- Code Listing 16 ----
public static class Listing16
{
    public static T GetMaxItem<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array cannot be null or empty");

        T maxValue = array[0];

        foreach (T item in array)
        {
            if (item.CompareTo(maxValue) > 0)
                maxValue = item;
        }

        return maxValue;
    }

    public static void Run()
    {
        int[] numbers = { 3, 7, 2, 9, 4 };
        Console.WriteLine($"Max item: {GetMaxItem(numbers)}");
    }
}
