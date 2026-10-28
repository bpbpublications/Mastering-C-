using Chapter21.Listings;


RunListing("Listing 1", Listing01.Run);
RunListing("Listing 2", Listing02.Run);
RunListing("Listing 3", Listing03.Run);
RunListing("Listing 4", Listing04.Run);
RunListing("Listing 5", Listing05.Run);
RunListing("Listing 6", Listing06.Run);

static void RunListing(string name, Action run)
{
    Console.WriteLine($"=== {name} ===");
    try
    {
        run();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"{name} failed: {ex.GetType().Name}: {ex.Message}");
    }
}
