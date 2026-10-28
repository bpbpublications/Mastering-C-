// ---- Code Listing 3 ----
using System.Security.Cryptography;

namespace Chapter21.Listings;

public static class SymmetricAesHelper
{
    public static byte[] Encrypt(string plaintext, byte[] key, byte[] iv)
    {
        using var aes = Aes.Create();
        aes.Key = key;
        aes.IV = iv;
        using var encryptor = aes.CreateEncryptor();
        using var memoryStream = new MemoryStream();
        using var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
        using var streamWriter = new StreamWriter(cryptoStream);
        streamWriter.Write(plaintext);
        streamWriter.Close();
        return memoryStream.ToArray();
    }

    public static string Decrypt(byte[] cipherText, byte[] key, byte[] iv)
    {
        using var aes = Aes.Create();
        aes.Key = key;
        aes.IV = iv;
        using var decryptor = aes.CreateDecryptor();
        using var memoryStream = new MemoryStream(cipherText);
        using var cryptoStream = new CryptoStream(memoryStream,
        decryptor, CryptoStreamMode.Read);
        using var streamReader = new StreamReader(cryptoStream);
        return streamReader.ReadToEnd();
    }
}

public static class Listing03
{
    public static void Run()
    {
        using var aes = Aes.Create();
        aes.GenerateKey();
        aes.GenerateIV();

        byte[] cipherText = SymmetricAesHelper.Encrypt("secret payload", aes.Key, aes.IV);
        string roundTrip = SymmetricAesHelper.Decrypt(cipherText, aes.Key, aes.IV);
        Console.WriteLine($"AES round trip succeeded: {roundTrip == "secret payload"}");
    }
}
