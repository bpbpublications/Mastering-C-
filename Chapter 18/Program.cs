
RunListing(1, Listing01.Run);
RunListing(2, Listing02.Run);
RunListing(3, () => { });
RunListing(4, () => { });
RunListing(5, Listing05.Run);
RunListing(6, () => { });
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
RunListing(17, Listing17.Run);
RunListing(18, Listing18.Run);
RunListing(19, Listing19.Run);
RunListing(20, Listing20.Run);
RunListing(21, Listing21.Run);

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
    Console.WriteLine();
}
