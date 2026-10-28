
using System.Linq.Expressions;

namespace Chapter12;

public static class Listing33
{
    public static void Run()
    {
        Func<int, int, int> myFunction = (x, y) => x + y;
        Console.WriteLine(myFunction(2, 3));
    }
}

public static class Listing34
{
    public static void Run()
    {
        Expression<Func<int, int, int>> myExpression = (x, y) => x + y;
        Console.WriteLine(myExpression);
    }
}

// ---- Code Listing 35 / 36 ----
public static class Listing35_36
{
    public static void Run()
    {
        Console.WriteLine("=== Listing 35 ===");
        Expression<Func<int, int>> square = n => n * n;

        Console.WriteLine("=== Listing 36 ===");
        Console.WriteLine(square);
        Console.WriteLine(square.Body);
        Console.WriteLine(square.Parameters[0]);
        var result = square.Compile();
        Console.WriteLine(result(10));
    }
}

// ---- Code Listing 37 / 38 / 39 ----
public static class Listing37_38_39
{
    public static void Run()
    {
        Console.WriteLine("=== Listing 37 ===");
        Expression<Func<int, int, int>> myExpression = (x, y) => x + y;

        Console.WriteLine("=== Listing 38 ===");
        Func<int, int, int> myCompiledExpression = myExpression.Compile();

        Console.WriteLine("=== Listing 39 ===");
        int result = myCompiledExpression(5, 10);
        Console.WriteLine(result);
    }
}

// ---- Code Listing 40 / 41 ----
public static class Listing40_41
{
    public static void Run()
    {
        Console.WriteLine("=== Listing 40 ===");
        Expression<Func<int, int, int>> expression = (x, y) => x + y;

        Console.WriteLine("=== Listing 41 ===");
        Console.WriteLine(expression);
    }
}

public static class Listing42
{
    public static void Run()
    {
        Expression<Func<int, int, int>> expression = (x, y) => x + y;
        var body = (BinaryExpression)expression.Body;
        var left = (ParameterExpression)body.Left;
        var right = (ParameterExpression)body.Right;
        Console.WriteLine($"Operation: {body.NodeType}");
        Console.WriteLine($"Left Operand: {left.Name}");
        Console.WriteLine($"Right Operand: {right.Name}");
    }
}

// ---- Code Listing 43 / 44 / 45 / 46 ----
public static class Listing43_46
{
    public static void Run()
    {
        Console.WriteLine("=== Listing 43 ===");
        ParameterExpression param = Expression.Parameter(typeof(int), "n");

        Console.WriteLine("=== Listing 44 ===");
        BinaryExpression body = Expression.Multiply(param, param);

        Console.WriteLine("=== Listing 45 ===");
        Expression<Func<int, int>> square = Expression.Lambda<Func<int, int>>(body, param);

        Console.WriteLine("=== Listing 46 ===");
        var compiled = square.Compile();
        Console.WriteLine(compiled(10));
    }
}

// ---- Code Listing 47 / 48 ----
public static class Listing47_48
{
    public static void Run()
    {
        Console.WriteLine("=== Listing 47 ===");
        var originalExpression = (Expression<Func<int, int>>)(x => x * x);

        Console.WriteLine("=== Listing 48 ===");
        var modifiedBody = Expression.Add(originalExpression.Body, Expression.Constant(1));
        var modified = Expression.Lambda<Func<int, int>>(modifiedBody, originalExpression.Parameters);
        var compiled = modified.Compile();
        Console.WriteLine(compiled(10));
    }
}
