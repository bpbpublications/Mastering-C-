// ---- Code Listing 7 ----
public class LogEntry
{
    public DateTime Timestamp { get; set; }
    public string Level { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
}

public class LogParser
{
    private static readonly Regex LogPattern = new Regex(
        @"(?<timestamp>\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2})\s+\[(?<level>\w+)\]\s+(?<message>.*)",
        RegexOptions.Compiled
    );

    public static LogEntry? ParseLogLine(string line)
    {
        var match = LogPattern.Match(line);
        if (!match.Success)
            return null;
        return new LogEntry
        {
            Timestamp = DateTime.Parse(match.Groups["timestamp"].Value),
            Level = match.Groups["level"].Value,
            Message = match.Groups["message"].Value
        };
    }
}
