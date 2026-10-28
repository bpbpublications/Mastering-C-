// ---- Code Listing 2 ----
using System.Security.Cryptography;
using System.Text;

namespace Chapter21.Listings;

public class HashingService
{
    public static string ComputeSHA256Hash(string input)
    {
        using (var sha256 = SHA256.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha256.ComputeHash(inputBytes);
            return Convert.ToHexString(hashBytes).ToLower();
        }
    }

    public static string HashPassword(string password)
    {
        byte[] salt = new byte[32];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(salt);
        }

        using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256))
        {
            byte[] hash = pbkdf2.GetBytes(32);
            byte[] hashBytes = new byte[64];
            Array.Copy(salt, 0, hashBytes, 0, 32);
            Array.Copy(hash, 0, hashBytes, 32, 32);
            return Convert.ToBase64String(hashBytes);
        }
    }

    public static bool VerifyPassword(string password, string storedHash)
    {
        byte[] hashBytes = Convert.FromBase64String(storedHash);
        byte[] salt = new byte[32];
        Array.Copy(hashBytes, 0, salt, 0, 32);

        using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256))
        {
            byte[] hash = pbkdf2.GetBytes(32);
            byte[] storedHashBytes = new byte[32];
            Array.Copy(hashBytes, 32, storedHashBytes, 0, 32);
            return CryptographicOperations.FixedTimeEquals(hash, storedHashBytes);
        }
    }
}

public static class Listing02
{
    public static void Run()
    {
        string hash = HashingService.ComputeSHA256Hash("some data");
        Console.WriteLine($"HashingService.ComputeSHA256Hash: {hash}");

        string storedHash = HashingService.HashPassword("S3cur3P@ssw0rd!");
        Console.WriteLine($"HashingService.HashPassword produced: {storedHash}");

        bool ok = HashingService.VerifyPassword("S3cur3P@ssw0rd!", storedHash);
        Console.WriteLine($"HashingService.VerifyPassword (correct password): {ok}");

        bool bad = HashingService.VerifyPassword("wrong-password", storedHash);
        Console.WriteLine($"HashingService.VerifyPassword (wrong password): {bad}");
    }
}
