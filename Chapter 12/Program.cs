
using Chapter12;

void RunListing(string label, Action run)
{
    Console.WriteLine($"=== Listing {label} ===");
    try
    {
        run();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[Listing {label} threw: {ex.GetType().Name}: {ex.Message}]");
    }
}

void RunGroup(Action run)
{
    try
    {
        run();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[Group threw: {ex.GetType().Name}: {ex.Message}]");
    }
}

RunListing("1", Listing01.Run);
RunListing("2", Listing02.Run);
RunListing("3", Listing03.Run);
RunListing("4", Listing04.Run);
RunListing("5", Listing05.Run);
RunListing("6", Listing06.Run);
RunListing("7", Listing07.Run);
RunListing("8", Listing08.Run);
RunListing("9", Listing09.Run);
RunListing("10", Listing10.Run);
RunListing("11", Listing11.Run);
RunListing("12", Listing12.Run);
RunGroup(Listing13_14.Run);
RunListing("15", Listing15.Run);
RunListing("16", Listing16.Run);
RunListing("17", Listing17.Run);
RunListing("18", Listing18.Run);
RunListing("19", Listing19.Run);
RunListing("20", Listing20.Run);
RunGroup(Listing21_22.Run);
RunListing("23", Listing23.Run);
RunListing("24", Listing24.Run);
RunListing("25", Listing25.Run);
RunListing("26", Listing26.Run);
RunListing("27", Listing27.Run);
RunListing("28", Listing28.Run);
RunListing("29", Listing29.Run);
RunListing("30", Listing30.Run);
RunListing("31", Listing31.Run);
RunListing("32", Listing32.Run);
RunListing("33", Listing33.Run);
RunListing("34", Listing34.Run);
RunGroup(Listing35_36.Run);
RunGroup(Listing37_38_39.Run);
RunGroup(Listing40_41.Run);
RunListing("42", Listing42.Run);
RunGroup(Listing43_46.Run);
RunGroup(Listing47_48.Run);

Console.WriteLine("=== Done ===");
