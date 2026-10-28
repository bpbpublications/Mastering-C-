// ---- Code Listing 8 ----
public static class Listing08
{
    public static void Run()
    {
        string?[] emails = new[]
                    {
                        "joydipkanjilal@gmail.com",
                        "joydip.kanjilal@yahoo.com",
                        "this-is-an-invalid-email-address",
                        "@yetanotherinvalidemail.com",
                        "email addresses cannot contain space characters@notallowed.com",
                        "",
                        null
                    };
        foreach (var email in emails)
        {
            bool isValid = NewEmailValidator.IsValidEmail(email);
            Console.WriteLine($"'{email}' is {(isValid ? "Valid" : "Invalid")}");
        }

    }
}

public class EmailValidatorCompiled
{
    private static readonly Regex EmailRegex = new Regex(
        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
        RegexOptions.Compiled
    );
    public static bool IsValidEmail(string? email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        return EmailRegex.IsMatch(email);
    }
}

public partial class NewEmailValidator
{
    [GeneratedRegex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
    private static partial Regex EmailRegex();

    public static bool IsValidEmail(string? email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;
        return EmailRegex().IsMatch(email);
    }
}
