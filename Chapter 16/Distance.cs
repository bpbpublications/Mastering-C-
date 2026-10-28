namespace Chapter16;

// ---- Code Listing 14 (class continues through Listing 21) ----
public class Distance : IEquatable<Distance>, IComparable<Distance>
{
    public int Kilometers { get; }
    public int Meters { get; }

    public Distance(int kilometers, int meters)
    {
        if (kilometers < 0 || meters < 0)
            throw new ArgumentException("The values of kms and meters must be non-negative.");
        Kilometers = kilometers + meters / 1000;
        Meters = meters % 1000;
    }

    private Distance(int distanceInMeters)
    {
        if (distanceInMeters < 0)
            throw new ArgumentException("The value of the parameter must be non-negative.");
        Kilometers = distanceInMeters / 1000;
        Meters = distanceInMeters % 1000;
    }

    // ---- Code Listing 15 ----
    private int DistanceInMeters => Kilometers * 1000 + Meters;

    private static void ValidateOperands(Distance d)
    {
        if (d == null)
            throw new ArgumentNullException(nameof(d));
    }

    private static void ValidateOperands(Distance a, Distance b)
    {
        if (a == null)
            throw new ArgumentNullException(nameof(a));
        if (b == null)
            throw new ArgumentNullException(nameof(b));
    }

    // ---- Code Listing 16 ----
    public static Distance operator +(Distance d)
    {
        ValidateOperands(d);
        return d;
    }

    public static Distance operator -(Distance d)
    {
        ValidateOperands(d);
        int distanceInMeters = -d.DistanceInMeters;

        if (distanceInMeters < 0)
            throw new InvalidOperationException("Resulting distance cannot be negative.");
        return new Distance(distanceInMeters);
    }

    public static Distance operator ++(Distance d)
    {
        ValidateOperands(d);
        return new Distance(d.DistanceInMeters + 1);
    }

    public static Distance operator --(Distance d)
    {
        ValidateOperands(d);
        int distanceInMeters = d.DistanceInMeters - 1;
        if (distanceInMeters < 0)
            throw new InvalidOperationException("Resulting distance cannot be negative.");
        return new Distance(distanceInMeters);
    }

    // ---- Code Listing 17 ----
    public static Distance operator +(Distance a, Distance b)
    {
        ValidateOperands(a, b);
        return new Distance(a.DistanceInMeters + b.DistanceInMeters);
    }

    public static Distance operator -(Distance a, Distance b)
    {
        ValidateOperands(a, b);
        int diff = a.DistanceInMeters - b.DistanceInMeters;
        if (diff < 0)
            throw new InvalidOperationException("Resulting distance cannot be negative.");
        return new Distance(diff);
    }

    public static Distance operator *(Distance distance, int scalar)
    {
        ValidateOperands(distance);
        if (scalar < 0)
            throw new ArgumentException("The value of scalar variable must be non-negative.");
        return new Distance(distance.DistanceInMeters * scalar);
    }

    public static Distance operator *(int scalar, Distance distance)
    {
        return distance * scalar;
    }

    public static Distance operator /(Distance distance, int scalar)
    {
        ValidateOperands(distance);
        if (scalar <= 0)
            throw new ArgumentException("Value of scalar variable cannot be zero or negative.");
        return new Distance(distance.DistanceInMeters / scalar);
    }

    // ---- Code Listing 18 ----
    public static bool operator ==(Distance a, Distance b)
    {
        if (ReferenceEquals(a, b))
            return true;
        if (a is null || b is null)
            return false;
        return a.DistanceInMeters == b.DistanceInMeters;
    }

    public static bool operator !=(Distance a, Distance b)
    {
        return !(a == b);
    }

    public static bool operator <(Distance a, Distance b)
    {
        ValidateOperands(a, b);
        return a.DistanceInMeters < b.DistanceInMeters;
    }

    public static bool operator >(Distance a, Distance b)
    {
        ValidateOperands(a, b);
        return a.DistanceInMeters > b.DistanceInMeters;
    }

    public static bool operator <=(Distance a, Distance b)
    {
        return a == b || a < b;
    }

    public static bool operator >=(Distance a, Distance b)
    {
        return a == b || a > b;
    }

    // ---- Code Listing 19 ----
    public override int GetHashCode()
    {
        return DistanceInMeters.GetHashCode();
    }

    public override string ToString()
    {
        return $"{Kilometers} km {Meters} m";
    }

    // ---- Code Listing 20 ----
    public bool Equals(Distance? other)
    {
        if (other is null) return false;
        return DistanceInMeters == other.DistanceInMeters;
    }

    public override bool Equals(object? obj) => Equals(obj as Distance);

    public int CompareTo(Distance? other)
    {
        if (other is null) return 1;
        return DistanceInMeters.CompareTo(other.DistanceInMeters);
    }

    // ---- Code Listing 21 ----
    public static implicit operator int(Distance distance) => distance.DistanceInMeters;

    public static explicit operator Distance(int meters) => new Distance(meters);
}

public static class Listing14
{
    public static void Run()
    {
        var d = new Distance(1, 1500);
        Console.WriteLine($"Kilometers={d.Kilometers}, Meters={d.Meters}");
    }
}

public static class Listing15
{
    public static void Run()
    {
        Console.WriteLine("Internal helpers added (DistanceInMeters, ValidateOperands) - see Listings 16-18 for usage.");
    }
}

public static class Listing16
{
    public static void Run()
    {
        var d = new Distance(0, 500);
        var plus = +d;
        var negatedZero = -new Distance(0, 0);
        var e = new Distance(0, 999);
        var incremented = ++e;
        Console.WriteLine($"+d -> {plus}");
        Console.WriteLine($"-zero -> {negatedZero}");
        Console.WriteLine($"++e -> {incremented}");
    }
}

public static class Listing17
{
    public static void Run()
    {
        var a = new Distance(1, 200);
        var b = new Distance(0, 900);
        Console.WriteLine($"a + b -> {a + b}");
        Console.WriteLine($"a - b -> {a - b}");
        Console.WriteLine($"a * 3 -> {a * 3}");
        Console.WriteLine($"3 * a -> {3 * a}");
        Console.WriteLine($"a / 2 -> {a / 2}");
    }
}

public static class Listing18
{
    public static void Run()
    {
        var a = new Distance(1, 0);
        var b = new Distance(1, 0);
        var c = new Distance(2, 0);
        Console.WriteLine($"a==b: {a == b}, a!=c: {a != c}, a<c: {a < c}, c>a: {c > a}, a<=b: {a <= b}, c>=a: {c >= a}");
    }
}

public static class Listing19
{
    public static void Run()
    {
        var a = new Distance(1, 0);
        var b = new Distance(1, 0);
        Console.WriteLine(a.ToString());
        Console.WriteLine($"a.Equals((object)b) -> {a.Equals((object)b)}");
        Console.WriteLine($"a.GetHashCode() == b.GetHashCode() -> {a.GetHashCode() == b.GetHashCode()}");
    }
}

public static class Listing20
{
    public static void Run()
    {
        var list = new List<Distance> { new Distance(2, 0), new Distance(1, 0), new Distance(1, 500) };
        list.Sort();
        foreach (var d in list)
            Console.WriteLine($"{d}");
        Console.WriteLine($"list[0].Equals(list[1]) -> {list[0].Equals(list[1])}");
    }
}

public static class Listing21
{
    public static void Run()
    {
        Distance d = new Distance(1, 500);
        int meters = d;
        Distance back = (Distance)2500;
        Console.WriteLine($"meters={meters}, back={back}");
    }
}
