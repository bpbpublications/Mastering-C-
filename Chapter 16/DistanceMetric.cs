namespace Chapter16;

// ---- Code Listing 22 ----
public class DistanceMetric
{
    public int Meters { get; set; }
    public int Centimeters { get; set; }

    public DistanceMetric(int meters, int centimeters)
    {
        Meters = meters;
        Centimeters = centimeters;
    }

    public static DistanceMetric operator +(DistanceMetric d1, DistanceMetric d2)
    {
        int total = (d1.Meters * 100 + d1.Centimeters) +
                       (d2.Meters * 100 + d2.Centimeters);

        return new DistanceMetric(total / 100, total % 100);
    }

    public override string ToString()
    {
        return $"{Meters}: m, {Centimeters}: cm";
    }
}

public static class Listing22
{
    public static void Run()
    {
        var a = new DistanceMetric(1, 80);
        var b = new DistanceMetric(0, 50);
        var sum = a + b;
        Console.WriteLine(sum);
    }
}
