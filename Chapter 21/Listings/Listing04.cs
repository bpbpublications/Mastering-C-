// ---- Code Listing 4 ----
using System.Security.Cryptography;

namespace Chapter21.Listings;

public static class Listing04
{
    public static void Run()
    {
        using var aes = Aes.Create();
        aes.GenerateKey();
        aes.GenerateIV();

        byte[] key = aes.Key;
        byte[] iv = aes.IV;

        Console.WriteLine($"Generated AES key ({key.Length * 8}-bit) and IV ({iv.Length * 8}-bit).");
    }
}
