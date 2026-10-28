// ---- Code Listing 18 (type declarations) ----
public interface IShape
{
    double Area();
}

public class Circle : IShape
{
    public double Radius { get; set; }
    public double Area() { return Math.PI * Math.Pow(Radius, 2); }
}
