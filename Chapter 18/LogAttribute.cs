// ---- Code Listing 6 ----
[AttributeUsage(AttributeTargets.Method)]
public class LogAttribute : Attribute
{
    public string Message { get; }
    public LogAttribute(string message) => Message = message;
}
