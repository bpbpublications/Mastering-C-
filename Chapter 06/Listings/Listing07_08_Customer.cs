namespace Chapter6;

// ---- Code Listing 7 ----
public partial class Customer
{
    public partial string FirstName { get; set; }
    public partial string LastName { get; set; }
}

// ---- Code Listing 8 ----
public partial class Customer
{
    private string _firstName = string.Empty;
    private string _lastName = string.Empty;

    public partial string FirstName
    {
        get => _firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("First Name cannot be empty.");
            _firstName = value;
        }
    }

    public partial string LastName
    {
        get => _lastName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Last Name cannot be empty.");
            _lastName = value;
        }
    }
}

public static class Listing07
{
    public static void Run()
    {
        Console.WriteLine("Customer declares FirstName/LastName as partial properties (implemented in Listing 8).");
    }
}

public static class Listing08
{
    public static void Run()
    {
        var customer = new Customer { FirstName = "Ada", LastName = "Lovelace" };
        Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}");

        try
        {
            customer.FirstName = "   ";
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Validation caught: {ex.Message}");
        }
    }
}
