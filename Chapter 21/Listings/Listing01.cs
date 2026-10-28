// ---- Code Listing 1 ----
using System.Security.Cryptography;
using System.Text;

namespace Chapter21.Listings;

public static class Listing01
{
    public static string ComputeSha256(string input)
    {
        using var sha256 = SHA256.Create();
        byte[] bytes = Encoding.UTF8.GetBytes(input);
        byte[] hash = sha256.ComputeHash(bytes);
        return Convert.ToHexString(hash);
    }

    public static void Run()
    {
        string hash = ComputeSha256("Hello, Chapter 21!");
        Console.WriteLine($"SHA-256 of \"Hello, Chapter 21!\" = {hash}");
    }
}
