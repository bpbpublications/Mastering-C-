namespace Chapter6;

// ---- Code Listing 14 ----
public class BaseClass
{
    protected int[] numbers = new int[5];
    public virtual int this[int index]
    {
        get
        {
            Console.WriteLine("Get accessor of the base class called.");
            return numbers[index];
        }
        set
        {
            Console.WriteLine("Set accessor of the base class called.");
            numbers[index] = value;
        }
    }
}

public class DerivedClass : BaseClass
{
    public override int this[int index]
    {
        get
        {
            Console.WriteLine("Get accessor of the derived class called.");
            return numbers[index];
        }
        set
        {
            Console.WriteLine("Set accessor of the derived class called.");
            numbers[index] = value;
        }
    }
}

public static class Listing14
{
    public static void Run()
    {
        DerivedClass derivedClass = new DerivedClass();
        derivedClass[0] = 10;
        Console.WriteLine($"derivedClass[0] = {derivedClass[0]}");
    }
}
