
using Chapter15;

RunListing("Listing 1", Listing01.Run);
RunListing("Listing 2", Listing02.Run);
RunListing("Listing 3", Listing03.Run);
RunListing("Listing 5", Listing05.Run);
RunListing("Listing 7", Listing07.Run);
RunListing("Listing 8", Listing08.Run);
RunListing("Listing 9", Listing09.Run);

static void RunListing(string label, Action run)
{
    Console.WriteLine($"=== {label} ===");
    try
    {
        run();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[{label}] Unhandled error: {ex.Message}");
    }
}
