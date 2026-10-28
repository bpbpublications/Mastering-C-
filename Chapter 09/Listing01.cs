namespace Chapter9;

// ---- Code Listing 1 ----
public static class Listing01
{
    public static void Run() => Method_A();

    static void Method_A()
    {
        try
        {
            Console.WriteLine("Inside method A");
            Method_B();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void Method_B()
    {
        try
        {
            int i = 10, j = 0;
            int z = i / j;
            Console.WriteLine("Inside method B");
        }
        catch (Exception)
        {
            throw;
        }
    }
}
