// ---- Code Listing 5 ----
public static class Listing05
{
    public static void Run()
    {
        string email = "someone@email.com";
        string phone = "123-456-7890.";
        string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        string phonePattern = @"\d{3}-\d{3}-\d{4}";
        Match emailMatch = Regex.Match(email, emailPattern);
        Match phoneMatch = Regex.Match(phone, phonePattern);
        Console.WriteLine($"The Email Address is: {emailMatch.Value}");
        Console.WriteLine($"The Phone Number is: {phoneMatch.Value}");
    }
}
