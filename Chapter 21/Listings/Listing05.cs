// ---- Code Listing 5 ----
using System.Security.Cryptography;
using System.Text;

namespace Chapter21.Listings;

public static class AsymmetricRsaHelper
{
    public static byte[] Encrypt(string data, RSA rsa)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(data);
        return rsa.Encrypt(bytes, RSAEncryptionPadding.OaepSHA256);
    }

    public static string Decrypt(byte[] cipher, RSA rsa)
    {
        byte[] decrypted = rsa.Decrypt(cipher, RSAEncryptionPadding.OaepSHA256);
        return Encoding.UTF8.GetString(decrypted);
    }
}

public static class Listing05
{
    public static void Run()
    {
        using var rsa = RSA.Create(2048);
        byte[] cipher = AsymmetricRsaHelper.Encrypt("top secret", rsa);
        string plain = AsymmetricRsaHelper.Decrypt(cipher, rsa);
        Console.WriteLine($"RSA round trip succeeded: {plain == "top secret"}");
    }
}
