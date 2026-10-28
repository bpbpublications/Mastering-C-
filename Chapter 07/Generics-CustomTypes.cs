namespace Chapter7;

// ---- Code Listing 14 ----
public class GenericArrayList<T>
{
    private T[] elements;
    private int position = -1;
    public int MaxItems { get; private set; }
    public GenericArrayList(int size)
    {
        elements = new T[size];
        MaxItems = size;
    }
    public void Add(T item)
    {
        if (position == elements.Length - 1)
            throw new InvalidOperationException("Stack overflow");
        elements[++position] = item;
    }
    public T this[int index]
    {
        get
        {
            if (index >= MaxItems)
                throw new ArgumentOutOfRangeException
                    ("Index cannot exceed count of items");
            return elements[index];
        }
        set
        {
            if (index >= MaxItems)
                throw new ArgumentOutOfRangeException
                    ("Index cannot exceed count of items");
            elements[index] = value;
        }
    }
}

// ---- Code Listing 15 ----
public static class Listing15
{
    public static void Run()
    {
        GenericArrayList<int> genericArrayList = new GenericArrayList<int>(10);
        genericArrayList.Add(125);
        Console.WriteLine(genericArrayList[0].ToString());
    }
}

// ---- Code Listing 16 ----
public static class Listing16
{
    public static void Run()
    {
        GenericArrayList<int> genericArrayList = new GenericArrayList<int>(10);
        genericArrayList.Add(125);
        Console.WriteLine(genericArrayList[0].ToString());
    }
}

// ---- Code Listing 17 ----
public class Stack<T>
{
    private T[] items;
    private int index = -1;
    public Stack(int maxItems)
    {
        items = new T[maxItems];
    }
    private T[] Items { get; }
    public void Push(T data)
    {
        items[++index] = data;
    }
    public T Pop()
    {
        return items[index--];
    }
}

// ---- Code Listing 18 ----
public interface IGenericRepository<T>
{
    void Create(T item);
    void Update(T item);
    void Delete(T item);
}

// ---- Code Listing 19 ----
public class GenericRepository<T> : IGenericRepository<T>
{
    private List<T> items = new List<T>();
    public void Create(T item)
    {
        items.Add(item);
    }
    public void Update(T item)
    {
        items.Add(item);
    }
    public void Delete(T item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
        }
        else
        {
            throw new InvalidOperationException("Record not available.");
        }
    }
}

// ---- Code Listing 20 ----
public struct GenericArray<T>
{
    private T[] array;
    public GenericArray(int size)
    {
        array = new T[size + 1];
    }
    public T AddItem(int index)
    {
        return array[index];
    }
    public void SetValue(int index, T value)
    {
        array[index] = value;
    }
}

// ---- Code Listing 21 ----
public static class Listing21
{
    public static T GetMaxItem<T>(T[] array) where T : IComparable<T>
    {
        T maxValue = array[0];
        foreach (T item in array)
        {
            if (item.CompareTo(maxValue) > 0)
                maxValue = item;
        }
        return maxValue;
    }
}
