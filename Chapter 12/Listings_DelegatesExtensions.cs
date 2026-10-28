
namespace Chapter12;

public static class Listing20
{
    // ---- Code Listing 20 ----
    public static void Run()
    {
        Console.WriteLine("Syntax template (WinForms-style):");
        Console.WriteLine("button.Click += delegate (object sender, EventArgs e) { /* ... */ };");
    }
}

// ---- Code Listing 21 / 22 ----
public static class Listing21_22
{
    public static void Run()
    {
        Console.WriteLine("=== Listing 21 ===");
        mySumDelegate delegateObj = delegate (int a, int b)
        {
            return a + b;
        };

        Console.WriteLine("=== Listing 22 ===");
        Console.WriteLine(delegateObj.Invoke(5, 10).ToString());
    }
}

public static class Listing23
{
    public static void Run()
    {
        Console.WriteLine(MyDelegateExample.delegateObj.Invoke(5, 10).ToString());
    }
}

public static class Listing24
{
    // ---- Code Listing 24 ----
    public static void Run()
    {
        Console.WriteLine("(type declaration - see IntegerExtensions in Types.cs)");
    }
}

public static class Listing25
{
    public static void Run()
    {
        int i = 1;
        bool isEven = i.IsEven();
        Console.WriteLine(isEven);
    }
}

public static class Listing26
{
    public static void Run()
    {
        int a = 10, b = 5;
        bool isGreater = a.IsGreaterThan(b);
        Console.WriteLine(isGreater);
    }
}

public static class Listing27
{
    // ---- Code Listing 27 ----
    public static void Run()
    {
        Console.WriteLine("(type declaration - see StringExtensions in Types.cs)");
    }
}

public static class Listing28
{
    public static void Run()
    {
        string text = "This is an example text";
        int ctr = text.WordCount();
        Console.WriteLine(ctr);
    }
}

public static class Listing29
{
    // ---- Code Listing 29 ----
    public static void Run()
    {
        Console.WriteLine("(type declaration - see TestExtensions in Types.cs)");
    }
}

public static class Listing30
{
    public static void Run()
    {
        string str = "this is a sample text".Pluralize().FirstLetterShouldBeInUpperCase();
        Console.WriteLine(str);
    }
}

public static class Listing31
{
    // ---- Code Listing 31 ----
    public static void Run()
    {
        Console.WriteLine("(type declaration - see ObjectExtensions in Types.cs)");
    }
}

public static class Listing32
{
    public static void Run()
    {
        int ctr = "This is a line of text for illustration purposes only.".WordCount();
        Console.WriteLine(ctr);
    }
}
