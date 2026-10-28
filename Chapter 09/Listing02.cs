namespace Chapter9;

// ---- Code Listing 2 ----
public static class Listing02
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
            Console.WriteLine("Inside method B");
            int i = 10, j = 0;
            int z = i / j;
        }
        catch (Exception)
        {
            throw;
        }
    }
}

// ---- Code Listing 3 ----
