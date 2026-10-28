namespace Chapter16;

public class Complex
{
    public double Real { get; }
    public double Imaginary { get; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // ---- Code Listing 4 ----
    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    public override string ToString() => $"{Real} + {Imaginary}i";
}

public static class Listing04
{
    public static void Run()
    {
        var a = new Complex(2, 3);
        var b = new Complex(1, 4);
        var sum = a + b;
        Console.WriteLine($"{a} + {b} = {sum}");
    }
}
