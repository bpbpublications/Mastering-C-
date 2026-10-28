// ---- Code Listing 6 ----
using System.Linq;

namespace Appendix;

public static class StringExtensions
{
    public static bool IsPalindrome(this string s) =>
        s == new string(s.Reverse().ToArray());
}

public static class Listing06
{
    public static void Run()
    {
        Console.WriteLine("\"level\".IsPalindrome() = " + "level".IsPalindrome());
        Console.WriteLine("\"hello\".IsPalindrome() = " + "hello".IsPalindrome());
    }
}
