namespace Chapter8;

// ---- Code Listing 6 ----
public static class Listing06
{
    public static void Run()
    {
        var sample = new Employee { ID = 1, FirstName = "Joydip", LastName = "Kanjilal" };
        Console.WriteLine($"Employee type declared: {sample.FirstName} {sample.LastName} (ID {sample.ID})");
    }
}
