using Chapter7;


RunListing(2, Listing02.Run);
RunListing(3, Listing03.Run);
RunListing(5, Listing05.Run);
RunListing(6, Listing06.Run);
RunListing(7, Listing07.Run);
RunListing(8, Listing08.Run);
RunListing(12, Listing12.Run);
RunListing(13, Listing13.Run);
RunListing(15, Listing15.Run);
RunListing(16, Listing16.Run);
RunListing(22, Listing22.Run);
RunListing(23, Listing23.Run);
RunListing(24, Listing24.Run);
RunListing(25, Listing25.Run);
RunListing(26, Listing26.Run);
RunListing(27, Listing27.Run);
RunListing(28, Listing28.Run);
RunListing(29, Listing29.Run);
RunListing(32, Listing32.Run);
RunListing(33, Listing33.Run);
RunListing(34, Listing34.Run);
RunListing(35, Listing35.Run);
RunListing(36, Listing36.Run);
RunListing(37, Listing37.Run);
RunListing(38, Listing38.Run);
RunListing(39, Listing39.Run);
RunListing(40, Listing40.Run);
RunListing(41, Listing41.Run);
RunListing(42, Listing42.Run);
RunListing(43, Listing43.Run);
RunListing(44, Listing44.Run);
RunListing(45, Listing45.Run);
RunListing(46, Listing46.Run);
RunListing(47, Listing47.Run);
RunListing(48, Listing48.Run);

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
