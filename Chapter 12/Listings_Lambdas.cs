
namespace Chapter12;

public static class Listing01
{
    // ---- Code Listing 1 ----
    public static void Run()
    {
        Console.WriteLine("Lambda syntax template: (input-parameters) => expression");
    }
}

public static class Listing02
{
    public static void Run()
    {
        Func<int, int> multiply = n => n * 3;
        Console.WriteLine(multiply(10));
    }
}

public static class Listing03
{
    public static void Run()
    {
        int[] integers = { 1, 2, 3, 4, 5 };
        var squaredIntegers = integers.Select(x => x * x);
        Console.WriteLine(string.Join(" ", squaredIntegers));
    }
}

public static class Listing04
{
    public static void Run()
    {
        int[] marks = { 72, 71, 65, 59, 91, 88 };
        int ctr = marks.Where(n => n > 60).Count();
        Console.WriteLine("Count of students with marks greater than 60 is: {0}", ctr);
    }
}

public static class Listing05
{
    public static void Run()
    {
        List<int> lstNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> lstOddNumbers = lstNumbers.FindAll(x => (x % 2) == 1);
        foreach (var number in lstOddNumbers)
        {
            Console.WriteLine("{0} ", number);
        }
    }
}

public static class Listing06
{
    // ---- Code Listing 6 ----
    public static void Run()
    {
        Console.WriteLine("Lambda syntax template: (input-parameters) => expression");
    }
}

public static class Listing07
{
    public static void Run()
    {
        Func<int, int, bool> check = (x, y) => x == y;
        Console.WriteLine(check(5, 5));
    }
}

public static class Listing08
{
    public static void Run()
    {
        Action message = () => Console.WriteLine("Hello, World!");
        message();
    }
}

public static class Listing09
{
    public static void Run()
    {
        Action display = () => Console.WriteLine();
        display();
    }
}

public static class Listing10
{
    public static void Run()
    {
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(10));
    }
}

public static class Listing11
{
    public static void Run()
    {
        Func<int, int, int> add = (x, y) => x + y;
        Console.WriteLine(add(5, 10));
    }
}

public static class Listing12
{
    public static void Run()
    {
        Action<string> display = name =>
        {
            string msg = $"Hello {name}!";
            Console.WriteLine(msg);
        };
        display("Joydip");
    }
}

// ---- Code Listing 13 / 14 ----
public static class Listing13_14
{
    private static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int x = 2; x <= n / 2; x++)
        {
            if (n % x == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static void Run()
    {
        Console.WriteLine("=== Listing 13 ===");
        Console.WriteLine("(IsPrime helper declared - see Listing13_14.IsPrime)");

        Console.WriteLine("=== Listing 14 ===");
        List<int> lstNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> primeNos = lstNumbers.FindAll(x => IsPrime(x));
        foreach (var n in primeNos)
        {
            Console.Write("{0} ", n);
        }
        Console.WriteLine();
    }
}

public static class Listing15
{
    public static void Run()
    {
        Func<int, int, int> sum = (a, b) =>
        {
            int result = a + b;
            Console.WriteLine($"The sum of the two integers is: {result}");
            return result;
        };
        sum(2, 3);
    }
}

public static class Listing16
{
    public static void Run()
    {
        var result = object (bool x) => x ? 1 : "false";
        Console.WriteLine(result(true));
    }
}

public static class Listing17
{
    public static void Run()
    {
        var integers = new int[] { 6, 8, 0, 3, 9, 1, 6, 4, 2, 5 };
        int integer = 6;
        var ctr = integers.Count(x => x == integer);
        Console.WriteLine($"The integer 6 is present {ctr} times.", ctr);
    }
}

public static class Listing18
{
    public static void Run()
    {
        List<int> integers = new List<int> { 6, 8, 0, 3, 9, 1, 6, 4, 2, 5 };
        int integer = 6;
        var ctr = integers.Count(x =>
        {
            return x == integer;
        });
        Console.WriteLine($"The integer 6 is present {ctr} times.");
    }
}

public static class Listing19
{
    public static void Run()
    {
        int x = 5;
        Func<int, int> multiply = n => n * x;
        var result = multiply(15);
        Console.WriteLine(result);
    }
}
