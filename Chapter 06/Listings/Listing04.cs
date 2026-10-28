namespace Chapter6;

// ---- Code Listing 4 ----
public class BaseVirtual
{
    protected int _id;
    public virtual int Id
    {
        get
        {
            Console.WriteLine("Get accessor of the Base class called.");
            return _id;
        }
        set
        {
            _id = value;
            Console.WriteLine("Set accessor of the Base class called.");
        }
    }
}

public class DerivedOverride : BaseVirtual
{
    public override int Id
    {
        get
        {
            Console.WriteLine("Get accessor of the Derived class called.");
            return _id;
        }
        set
        {
            _id = value;
            Console.WriteLine("Set accessor of the Derived class called.");
        }
    }
}

public static class Listing04
{
    public static void Run()
    {
        DerivedOverride derived = new DerivedOverride();
        derived.Id = 0;
    }
}
