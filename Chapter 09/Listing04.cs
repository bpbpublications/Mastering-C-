namespace Chapter9;

// ---- Code Listing 4 ----
public class InvalidInputException : System.Exception
{
    public InvalidInputException()
        : base()
    {
    }

    public InvalidInputException(string message)
        : base(message)
    {
    }

    public InvalidInputException(string message, System.Exception inner)
        : base(message, inner)
    {
    }

    protected InvalidInputException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
    {
    }
}

public static class Listing04
{
    public static void Run()
    {
        try
        {
            throw new InvalidInputException("Demo: invalid input supplied");
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine($"Caught custom exception: {ex.Message}");
        }
    }
}
