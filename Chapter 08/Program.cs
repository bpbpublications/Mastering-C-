using Chapter8;


RunListingAsync(1, () => Listing01.RunAsync());
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
RunListing(13, Listing13.Run);
RunListing(14, Listing14.Run);
RunListing(15, Listing15.Run);
RunListing(16, Listing16.Run);
RunListingAsync(17, () => Listing17.RunAsync());
RunListing(18, Listing18.Run);
RunListing(19, Listing19.Run);
RunListing(20, Listing20.Run);
RunListing(21, Listing21.Run);
RunListingAsync(22, () => Listing22.RunAsync());
RunListingAsync(23, () => Listing23.RunAsync());
RunListing(24, Listing24.Run);
RunListing(25, Listing25.Run);
RunListing(26, Listing26.Run);

return;

static void RunListing(int number, Action run)
{
    Console.WriteLine($"=== Listing {number} ===");
    try
    {
        run();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Listing {number} threw {ex.GetType().Name}: {ex.Message}");
    }
}

static void RunListingAsync(int number, Func<Task> run)
{
    Console.WriteLine($"=== Listing {number} ===");
    try
    {
        run().GetAwaiter().GetResult();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Listing {number} threw {ex.GetType().Name}: {ex.Message}");
    }
}
