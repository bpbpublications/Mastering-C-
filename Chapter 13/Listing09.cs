// ---- Code Listing 9 ----
public class GenericArrayList<T>
{
    private T[] elements;
    private int position = -1;

    public int MaxItems { get; private set; }
    public int Count => position + 1;

    public GenericArrayList(int size)
    {
        if (size <= 0)
            throw new ArgumentException("Size must be greater than zero.");

        elements = new T[size];
        MaxItems = size;
    }

    public void Add(T item)
    {
        if (position >= MaxItems - 1)
            throw new InvalidOperationException("Array is full. Cannot add more items.");

        elements[++position] = item;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index > position)
                throw new ArgumentOutOfRangeException("Index is out of bounds.");

            return elements[index];
        }
        set
        {
            if (index < 0 || index > position)
                throw new ArgumentOutOfRangeException("Index is out of bounds.");

            elements[index] = value;
        }
    }
}

public static class Listing09
{
    public static void Run()
    {
        Console.WriteLine("GenericArrayList<T> type defined here (see Listing 11 for usage).");
    }
}
