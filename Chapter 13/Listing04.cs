// ---- Code Listing 4 ----
public class GenericRepositoryBasic<T>
{
    public void Add(T item)
    {
    }

    public T GetById(int id)
    {
        return default!;
    }
}

public static class Listing04
{
    public static void Run()
    {
        var repository = new GenericRepositoryBasic<string>();
        repository.Add("Sample item");
        Console.WriteLine("GenericRepositoryBasic<T> created (Add/GetById are stubs - implementation omitted for brevity).");
    }
}
