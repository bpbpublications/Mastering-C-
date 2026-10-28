// ---- Code Listing 9 ----
public class OptimizedRegexHelper
{
    private static readonly Regex EmailPattern = new Regex(
        @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);
    private static readonly Regex LogPattern = new Regex(
        @"^(?<timestamp>\d{4}-\d{2}-\d{2}.*?)(?<level>Error|Warning).*?$",
        RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.IgnoreCase);
    private static readonly Regex ComplexPattern = new Regex(
        @"(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)",
        RegexOptions.Compiled,
        TimeSpan.FromSeconds(1));

    public bool IsValidEmail(string email)
    {
        try
        {
            return EmailPattern.IsMatch(email);
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }
    public bool IsValidLog(string logData)
    {
        try
        {
            return LogPattern.IsMatch(logData);
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }
    public bool IsValidPattern(string pattern)
    {
        try
        {
            return ComplexPattern.IsMatch(pattern);
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }
}
