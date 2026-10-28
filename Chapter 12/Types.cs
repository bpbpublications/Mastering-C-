
namespace Chapter12;

// ---- Code Listing 21 / 23 ----
public delegate int mySumDelegate(int x, int y);

// ---- Code Listing 23 ----
public static class MyDelegateExample
{
    public static mySumDelegate delegateObj = delegate (int a, int b)
    {
        return a + b;
    };
}

// ---- Code Listing 24 ----
public static class IntegerExtensions
{
    public static bool IsGreaterThan(this int i, int j)
    {
        return i > j;
    }
    public static bool IsEven(this int i)
    {
        return (i % 2) == 0;
    }
}

// ---- Code Listing 27 ----
public static class StringExtensions
{
    public static bool IsUpperCase(this string text)
    {
        return text.ToUpper().Equals(text);
    }
    public static int WordCount(this string text)
    {
        return text.Split(new char[] { ' ', '.', ',' }).Length;
    }
}

// ---- Code Listing 29 ----
public static class TestExtensions
{
    public static string FirstLetterShouldBeInUpperCase(this string s)
    {
        return string.IsNullOrEmpty(s) ? s : char.ToUpper(s[0]) + s.Substring(1);
    }
    public static string Pluralize(this string s)
    {
        return s.EndsWith("s") ? s : s + "s";
    }
}

// ---- Code Listing 31 ----
public static class ObjectExtensions
{
    public static int WordCount(this object text)
    {
        return text.ToString()!.Split(new char[] { ' ', '.', ',' }).Length;
    }
}
