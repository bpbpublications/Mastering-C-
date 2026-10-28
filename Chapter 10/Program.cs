using Chapter10;


RunListing("Listing 1", Listing01.Run);
RunListing("Listing 2", Listing02.Run);
RunListing("Listing 3", Listing03.Run);
RunListing("Listing 4", Listing04.Run);

static void RunListing(string label, Action run)
{
    Console.WriteLine($"=== {label} ===");
    try
    {
        run();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[{label} failed: {ex.GetType().Name}: {ex.Message}]");
    }
}
