// ---- Code Listing 10 ----
public class RegexCache
{
    private static readonly ConcurrentDictionary<string, Regex> _cache = new();
    private static readonly object _lock = new object();
    public static Regex GetOrCreate(string pattern, RegexOptions options = RegexOptions.Compiled)
    {
        string key = $"{pattern}_{options}";

        return _cache.GetOrAdd(key, _ =>
        {
            lock (_lock)
            {
                return new Regex(pattern, options, TimeSpan.FromSeconds(2));
            }
        });
    }
    public static bool IsMatch(string input, string pattern, RegexOptions options = RegexOptions.Compiled)
    {
        var regex = GetOrCreate(pattern, options);
        try
        {
            return regex.IsMatch(input);
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }
}
