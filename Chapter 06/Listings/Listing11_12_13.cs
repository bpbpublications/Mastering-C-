namespace Chapter6;

// ---- Code Listing 11 ----
public class A
{
    private int[] numbers = new int[5];
    public virtual int this[int index]
    {
        get
        {
            Console.WriteLine("The Get accessor of the base class has been called.");
            return numbers[index];
        }
        set
        {
            Console.WriteLine("The Set accessor of the base class has been called.");
            numbers[index] = value;
        }
    }
}

public static class Listing11
{
    public static void Run()
    {
        Console.WriteLine("Class A declares a virtual indexer (used in Listing 13).");
    }
}

// ---- Code Listing 12 ----
public class B : A
{
    private int[] numbers = new int[5];
    public override int this[int index]
    {
        get
        {
            Console.WriteLine("The Get accessor of the derived class has been called.");
            return numbers[index];
        }
        set
        {
            Console.WriteLine("The Set accessor of the derived class has been called.");
            numbers[index] = value;
        }
    }
}

public static class Listing12
{
    public static void Run()
    {
        Console.WriteLine("Class B overrides A's indexer (used in Listing 13).");
    }
}

// ---- Code Listing 13 ----
public static class Listing13
{
    public static void Run()
    {
        A a = new B();
        a[0] = 1;
        Console.WriteLine($"The value is {a[0]}");
    }
}
