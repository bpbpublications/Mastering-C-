// ---- Code Listing 6 ----
using System.Security.Cryptography;
using System.Text;

namespace Chapter21.Listings;

public static class SymmetricEncryptionService
{
    public static string GenerateKey()
    {
        using var aes = Aes.Create();
        aes.GenerateKey();
        return Convert.ToBase64String(aes.Key);
    }

    public static string Encrypt(string data, string keyBase64)
    {
        byte[] key = Convert.FromBase64String(keyBase64);
        using var aes = Aes.Create();
        aes.Key = key;
        aes.GenerateIV();

        byte[] cipherBytes = SymmetricAesHelper.Encrypt(data, key, aes.IV);
        byte[] combined = new byte[aes.IV.Length + cipherBytes.Length];
        Buffer.BlockCopy(aes.IV, 0, combined, 0, aes.IV.Length);
        Buffer.BlockCopy(cipherBytes, 0, combined, aes.IV.Length, cipherBytes.Length);
        return Convert.ToBase64String(combined);
    }

    public static string Decrypt(string encryptedBase64, string keyBase64)
    {
        byte[] key = Convert.FromBase64String(keyBase64);
        byte[] combined = Convert.FromBase64String(encryptedBase64);

        byte[] iv = new byte[16];
        byte[] cipherBytes = new byte[combined.Length - iv.Length];
        Buffer.BlockCopy(combined, 0, iv, 0, iv.Length);
        Buffer.BlockCopy(combined, iv.Length, cipherBytes, 0, cipherBytes.Length);

        return SymmetricAesHelper.Decrypt(cipherBytes, key, iv);
    }
}

public static class AsymmetricEncryptionService
{
    public static string Encrypt(string data, string recipientPublicKeyPem)
    {
        using var rsa = RSA.Create();
        rsa.ImportFromPem(recipientPublicKeyPem);
        byte[] cipher = AsymmetricRsaHelper.Encrypt(data, rsa);
        return Convert.ToBase64String(cipher);
    }

    public static string Decrypt(string cipherBase64, string recipientPrivateKeyPem)
    {
        using var rsa = RSA.Create();
        rsa.ImportFromPem(recipientPrivateKeyPem);
        byte[] cipher = Convert.FromBase64String(cipherBase64);
        return AsymmetricRsaHelper.Decrypt(cipher, rsa);
    }
}

public class HybridEncryptionService
{
    public class EncryptedPackage
    {
        public string EncryptedData { get; set; } = string.Empty;
        public string EncryptedKey { get; set; } = string.Empty;
        public string IV { get; set; } = string.Empty;
    }

    public static EncryptedPackage EncryptLargeData(string data, string recipientPublicKey)
    {
        string aesKey = SymmetricEncryptionService.GenerateKey();
        string encryptedData = SymmetricEncryptionService.Encrypt(data, aesKey);
        string encryptedKey = AsymmetricEncryptionService.Encrypt(aesKey, recipientPublicKey);

        return new EncryptedPackage
        {
            EncryptedData = encryptedData,
            EncryptedKey = encryptedKey
        };
    }

    public static string DecryptLargeData(EncryptedPackage package, string recipientPrivateKey)
    {
        string aesKey = AsymmetricEncryptionService.Decrypt(package.EncryptedKey, recipientPrivateKey);

        return SymmetricEncryptionService.Decrypt(package.EncryptedData, aesKey);
    }
}

public static class Listing06
{
    public static void Run()
    {
        using var rsa = RSA.Create(2048);
        string publicKeyPem = rsa.ExportRSAPublicKeyPem();
        string privateKeyPem = rsa.ExportRSAPrivateKeyPem();

        string original = "A payload too large to encrypt directly with RSA.";
        var package = HybridEncryptionService.EncryptLargeData(original, publicKeyPem);
        string roundTrip = HybridEncryptionService.DecryptLargeData(package, privateKeyPem);

        Console.WriteLine($"Hybrid encryption round trip succeeded: {roundTrip == original}");
    }
}
