// ---- Code Listing 15 ----
public struct GenericArray<T>
{
    private T[] array;

    public GenericArray(int size)
    {
        array = new T[size + 1];
    }

    public T GetValue(int index)
    {
        return array[index];
    }

    public void SetValue(int index, T value)
    {
        array[index] = value;
    }
}

public static class Listing15
{
    public static void Run()
    {
        var genericArray = new GenericArray<int>(5);
        genericArray.SetValue(0, 42);
        Console.WriteLine($"genericArray[0] = {genericArray.GetValue(0)}");
    }
}
