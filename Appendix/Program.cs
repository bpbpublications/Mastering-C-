using Appendix;

RunListing(1, Listing01.Run);
RunListing(2, Listing02.Run);
RunListing(3, Listing03.Run);
RunListing(4, Listing04.Run);
RunListing(5, Listing05.Run);
RunListing(6, Listing06.Run);
RunListing(7, Listing07.Run);
RunListing(8, Listing08.Run);
RunListing(9, Listing09.Run);
RunListing(10, Listing10.Run);
RunListing(11, Listing11.Run);
RunListing(12, Listing12.Run);
await RunListingAsync(13, Listing13.RunAsync);

static void RunListing(int number, Action run)
{
    Console.WriteLine($"=== Listing {number} ===");
    try
    {
        run();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Listing {number} threw: {ex.GetType().Name}: {ex.Message}");
    }
}

static async Task RunListingAsync(int number, Func<Task> run)
{
    Console.WriteLine($"=== Listing {number} ===");
    try
    {
        await run();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Listing {number} threw: {ex.GetType().Name}: {ex.Message}");
    }
}
