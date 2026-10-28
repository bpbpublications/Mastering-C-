namespace Chapter6;

// ---- Code Listing 15 ----
public abstract class BaseClassAbstract
{
    protected int[] numbers = new int[5];

    public abstract int this[int index] { get; set; }
}

public class DerivedClassAbstract : BaseClassAbstract
{
    public override int this[int index]
    {
        get { return numbers[index]; }
        set { numbers[index] = value; }
    }
}

public static class Listing15
{
    public static void Run()
    {
        DerivedClassAbstract derivedClassAbstract = new DerivedClassAbstract();
        derivedClassAbstract[0] = 5;
        Console.WriteLine($"derivedClassAbstract[0] = {derivedClassAbstract[0]}");
    }
}
