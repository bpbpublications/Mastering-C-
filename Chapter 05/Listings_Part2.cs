
public static class Listing14
{
    public static void Run()
    {
        int[] numbers = { 17, 23, 4, 59, 27, 36, 96, 9, 1, 3 };
        Array.Sort(numbers);

        Array.Reverse(numbers);
        Console.WriteLine("Reversed Array:");
        foreach (var n in numbers) Console.Write(n + " ");
        Console.WriteLine();
    }
}

public static class Listing15
{
    public static void Run()
    {
        int[] numbers = { 10, 25, 30, 45, 50, 55, 60 };
        Console.WriteLine($"numbers: [{string.Join(", ", numbers)}]");
    }
}

public static class Listing16
{
    public static void Run()
    {
        int[] numbers = { 10, 25, 30, 45, 50, 55, 60 };
        var data = numbers.Where(n => n > 50);
        Console.WriteLine("Integers greater than 50:");
        foreach (var n in data)
        {
            Console.WriteLine(n);
        }
    }
}

public static class Listing17
{
    public static void Run()
    {
        int[] numbers = { 10, 25, 30, 45, 50, 55, 60 };
        int f = numbers.FirstOrDefault(n => n % 5 == 0);
        Console.WriteLine("\nFirst number divisible by 5: " + f);
    }
}

public static class Listing18
{
    public static void Run()
    {
        int[] numbers = { 10, 25, 30, 45, 50, 55, 60 };
        var sortedDesc = numbers.OrderByDescending(n => n);
        Console.WriteLine("\nNumbers sorted descending:");
        foreach (var num in sortedDesc)
        {
            Console.WriteLine(num);
        }
    }
}

public static class Listing19
{
    public static void Run()
    {
        int[] numbers = { 10, 25, 30, 45, 50, 55, 60 };
        int data = numbers.Count(n => n < 50);
        Console.WriteLine("\nCount of numbers less than 50: " + data);
    }
}

public static class Listing20
{
    public static void Run()
    {
        int[] numbers = { 10, 25, 30, 45, 50, 55, 60 };
        var squares = numbers.Select(n => n * n);
        Console.WriteLine("\nSquares of numbers:");
        foreach (var sq in squares)
        {
            Console.WriteLine(sq);
        }
    }
}

public static class Listing21
{
    public static void Run()
    {
        int[][] jaggedArray = new int[5][];
        Console.WriteLine($"Created a jagged array with {jaggedArray.Length} rows (elements not yet initialized).");
    }
}

public static class Listing22
{
    public static void Run()
    {
        int[][] jaggedArray = new int[5][];
        jaggedArray[0] = new int[3];
        jaggedArray[1] = new int[5];
        jaggedArray[2] = new int[4];
        jaggedArray[3] = new int[5];
        jaggedArray[4] = new int[3];

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine($"Row {i} length: {jaggedArray[i].Length}");
        }
    }
}

public static class Listing23
{
    public static void Run()
    {
        var mixedList = new List<object> { 10, 20, "Joydip", 9.8, new List<string> { "ABC", "XYZ" } };
        foreach (var item in mixedList)
        {
            if (item is int intValue)
                Console.WriteLine($"Integer: {intValue}");
            else if (item is string strValue)
                Console.WriteLine($"String: {strValue}");
            else if (item is double dblValue)
                Console.WriteLine($"Double: {dblValue}");
            else if (item is List<string> listValue)
                Console.WriteLine($"List: {string.Join(", ", listValue)}");
        }
    }
}

public static class Listing24
{
    public static void Run()
    {
        int[] numbers = { 5, 10, 8, 3, 6, 12 };

        var filtered = numbers.Where(n => n > 6);

        var sorted = filtered.OrderBy(n => n);

        var transformed = sorted.Select(n => n * 10);

        int sum = transformed.Sum();

        Console.WriteLine("Numbers greater than 6, sorted and multiplied by 10:");
        foreach (var num in transformed)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("Sum: " + sum);
    }
}

public static class Listing25
{
    public static void Run()
    {
        int[] numbers = { 10, 25, 30, 45, 50, 55, 60 };

        int f = numbers.FirstOrDefault(n => n % 2 == 0);
        Console.WriteLine("First even number: " + f);

        bool result = numbers.Any(n => n > 10);
        Console.WriteLine("Any number greater than 10: " + result);

        var distinctNumbers = numbers.Distinct();
        Console.WriteLine("Distinct numbers: " + string.Join(", ", distinctNumbers));
    }
}
