namespace Chapter16;

// ---- Code Listing 5 (class continues through Listing 13) ----
public class DistanceV1
{
    public int Feet { get; }
    public int Inches { get; }

    public DistanceV1(int feet, int inches)
    {
        Feet = feet + inches / 12;
        Inches = inches % 12;
    }

    private DistanceV1(int distanceInMeters)
    {
        Feet = distanceInMeters / 12;
        Inches = distanceInMeters % 12;
    }

    private int DistanceInMeters => Feet * 12 + Inches;

    // ---- Code Listing 13 ----
    private static void ValidateOperands(DistanceV1 a, DistanceV1 b)
    {
        if (a == null)
            throw new ArgumentNullException(nameof(a));

        if (b == null)
            throw new ArgumentNullException(nameof(b));
    }

    private static void ValidateOperands(DistanceV1 d)
    {
        if (d == null)
            throw new ArgumentNullException(nameof(d));
    }

    // ---- Code Listing 6 ----
    public static DistanceV1 operator +(DistanceV1 d)
    {
        ValidateOperands(d);
        return d;
    }

    // ---- Code Listing 7 ----
    public static DistanceV1 operator -(DistanceV1 d)
    {
        ValidateOperands(d);
        int distanceInMeters = -d.DistanceInMeters;
        if (distanceInMeters < 0)
            throw new InvalidOperationException("Resulting distance cannot be negative.");
        return new DistanceV1(distanceInMeters);
    }

    // ---- Code Listing 8 ----
    public static DistanceV1 operator ++(DistanceV1 d)
    {
        ValidateOperands(d);
        return new DistanceV1(d.DistanceInMeters + 1);
    }

    public static DistanceV1 operator --(DistanceV1 d)
    {
        ValidateOperands(d);
        int distanceInMeters = d.DistanceInMeters - 1;
        if (distanceInMeters < 0)
            throw new InvalidOperationException("Resulting distance cannot be negative.");
        return new DistanceV1(distanceInMeters);
    }

    // ---- Code Listing 9 ----
    public static DistanceV1 operator +(DistanceV1 a, DistanceV1 b)
    {
        ValidateOperands(a, b);
        return new DistanceV1(a.DistanceInMeters + b.DistanceInMeters);
    }

    public static DistanceV1 operator -(DistanceV1 a, DistanceV1 b)
    {
        ValidateOperands(a, b);
        int diff = a.DistanceInMeters - b.DistanceInMeters;
        if (diff < 0)
            throw new InvalidOperationException("Resulting distance cannot be negative.");
        return new DistanceV1(diff);
    }

    // ---- Code Listing 10 ----
    public static DistanceV1 operator *(DistanceV1 distance, int scalar)
    {
        ValidateOperands(distance);
        if (scalar < 0)
            throw new ArgumentException("The value of the scalar variable cannot be negative.");
        return new DistanceV1(distance.DistanceInMeters * scalar);
    }

    public static DistanceV1 operator /(DistanceV1 distance, int scalar)
    {
        ValidateOperands(distance);
        if (scalar <= 0)
            throw new ArgumentException("The scalar variable must be positive and non-zero.");
        return new DistanceV1(distance.DistanceInMeters / scalar);
    }

    // ---- Code Listing 11 ----
    public static bool operator ==(DistanceV1 a, DistanceV1 b)
    {
        if (ReferenceEquals(a, b))
            return true;
        if (a is null || b is null)
            return false;
        return a.DistanceInMeters == b.DistanceInMeters;
    }

    public static bool operator !=(DistanceV1 a, DistanceV1 b) => !(a == b);

    // ---- Code Listing 12 ----
    public static bool operator <(DistanceV1 a, DistanceV1 b)
    {
        ValidateOperands(a, b);
        return a.DistanceInMeters < b.DistanceInMeters;
    }

    public static bool operator >(DistanceV1 a, DistanceV1 b)
    {
        ValidateOperands(a, b);
        return a.DistanceInMeters > b.DistanceInMeters;
    }

    public static bool operator <=(DistanceV1 a, DistanceV1 b) => a == b || a < b;
    public static bool operator >=(DistanceV1 a, DistanceV1 b) => a == b || a > b;

    public override bool Equals(object? obj) => obj is DistanceV1 other && this == other;
    public override int GetHashCode() => DistanceInMeters.GetHashCode();
}

public static class Listing05
{
    public static void Run()
    {
        var d = new DistanceV1(5, 15);
        Console.WriteLine($"Distance: {d.Feet} ft {d.Inches} in");
    }
}

public static class Listing06
{
    public static void Run()
    {
        var d = new DistanceV1(3, 6);
        var result = +d;
        Console.WriteLine($"+d -> {result.Feet} ft {result.Inches} in");
    }
}

public static class Listing07
{
    public static void Run()
    {
        var d = new DistanceV1(0, 0);
        var result = -d;
        Console.WriteLine($"-d -> {result.Feet} ft {result.Inches} in");
    }
}

public static class Listing08
{
    public static void Run()
    {
        var d = new DistanceV1(1, 0);
        var incremented = ++d;
        var decremented = --d;
        Console.WriteLine($"++d -> {incremented.Feet} ft {incremented.Inches} in; --d -> {decremented.Feet} ft {decremented.Inches} in");
    }
}

public static class Listing09
{
    public static void Run()
    {
        var a = new DistanceV1(2, 0);
        var b = new DistanceV1(1, 6);
        var sum = a + b;
        var diff = a - b;
        Console.WriteLine($"a + b -> {sum.Feet} ft {sum.Inches} in");
        Console.WriteLine($"a - b -> {diff.Feet} ft {diff.Inches} in");
    }
}

public static class Listing10
{
    public static void Run()
    {
        var d = new DistanceV1(2, 0);
        var scaled = d * 3;
        var divided = d / 2;
        Console.WriteLine($"d * 3 -> {scaled.Feet} ft {scaled.Inches} in");
        Console.WriteLine($"d / 2 -> {divided.Feet} ft {divided.Inches} in");
    }
}

public static class Listing11
{
    public static void Run()
    {
        var a = new DistanceV1(1, 0);
        var b = new DistanceV1(1, 0);
        Console.WriteLine($"a == b -> {a == b}");
        Console.WriteLine($"a != b -> {a != b}");
    }
}

public static class Listing12
{
    public static void Run()
    {
        var a = new DistanceV1(1, 0);
        var b = new DistanceV1(2, 0);
        Console.WriteLine($"a < b -> {a < b}, a > b -> {a > b}, a <= b -> {a <= b}, a >= b -> {a >= b}");
    }
}

public static class Listing13
{
    public static void Run()
    {
        DistanceV1? nullDistance = null;
        var result = nullDistance! + new DistanceV1(1, 0);
        Console.WriteLine($"Unreachable: {result.Feet} ft {result.Inches} in");
    }
}
