
using Chapter14.Listings;

Console.WriteLine("Chapter 14 - Threading Listings Demo");
Console.WriteLine();

RunListing("1-3", Group01to03.Run);
RunListing("4", Listing04.Run);
RunListing("5", Listing05.Run);
RunListing("6", Listing06.Run);
RunListing("7", Listing07.Run);
RunListing("8", Listing08.Run);
RunListing("9", Listing09.Run);
RunListing("10", Listing10.Run);
RunListing("11", Listing11.Run);
RunListing("12", Listing12.Run);
RunListing("13", Listing13.Run);
RunListing("14", Listing14.Run);
RunListing("15", Listing15.Run);
RunListing("16", Listing16.Run);
RunListing("17", Listing17.Run);
RunListing("18-19", Group18to19.Run);
RunListing("20", Listing20.Run);
RunListing("21", Listing21.Run);
RunListing("22", Listing22.Run);
RunListing("23", Listing23.Run);
RunListing("24-25", Group24to25.Run);
RunListing("26", Listing26.Run);
RunListing("27", Listing27.Run);
RunListing("28", Listing28.Run);
RunListing("29", Listing29.Run);
RunListing("30", Listing30.Run);
RunListing("31", Listing31.Run);
RunListing("32-33", Group32to33.Run);

Console.WriteLine();
Console.WriteLine("Done.");

static void RunListing(string number, Action run)
{
    Console.WriteLine($"=== Listing {number} ===");
    try
    {
        run();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[Listing {number}] Unhandled exception escaped Run(): {ex.GetType().Name}: {ex.Message}");
    }
    Console.WriteLine();
}
