// ---- Code Listing 13 ----
public interface IGenericRepository<T>
{
    void Create(T item);
    void Update(T item);
    void Delete(T item);
}

public static class Listing13
{
    public static void Run()
    {
        Console.WriteLine("IGenericRepository<T> interface defined here (see Listing 14 for the implementation).");
    }
}

// ---- Code Listing 14 ----
public class GenericRepository<T> : IGenericRepository<T>
{
    private List<T> items = new List<T>();

    public void Create(T item)
    {
        items.Add(item);
    }

    public void Update(T item)
    {
        int index = items.IndexOf(item);
        if (index >= 0)
        {
            items[index] = item;
        }
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

public static class Listing14
{
    public static void Run()
    {
        var repository = new GenericRepository<string>();
        repository.Create("First item");
        repository.Update("First item");
        Console.WriteLine("GenericRepository<T> created; item created and updated.");
    }
}
