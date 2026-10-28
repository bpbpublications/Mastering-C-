// ---- Code Listing 12 ----
public class SimpleStack<T>
{
    private T[] items;
    private int index = -1;

    public int Capacity { get; }
    public int Count => index + 1;

    public SimpleStack(int maxItems)
    {
        if (maxItems <= 0)
            throw new ArgumentException("Stack size must be greater than zero.");

        items = new T[maxItems];
        Capacity = maxItems;
    }

    public void Push(T data)
    {
        if (index >= items.Length - 1)
            throw new InvalidOperationException("Stack overflow: Cannot push more items.");

        items[++index] = data;
    }

    public T Pop()
    {
        if (index < 0)
            throw new InvalidOperationException("Stack underflow: Cannot pop from an empty stack.");

        return items[index--];
    }

    public T Peek()
    {
        if (index < 0)
            throw new InvalidOperationException("Stack is empty.");

        return items[index];
    }
}

public static class Listing12
{
    public static void Run()
    {
        SimpleStack<int> stack = new SimpleStack<int>(5);
        for (int i = 1; i <= 5; i++)
            stack.Push(i);

        Console.WriteLine($"Stack count after pushing 1..5: {stack.Count}");
    }
}
