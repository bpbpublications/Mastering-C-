using Chapter9;


Console.WriteLine("=== Listing 1 ===");
try
{
    Listing01.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Listing 1 failed: {ex.Message}");
}

Console.WriteLine("=== Listing 2 ===");
try
{
    Listing02.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Listing 2 failed: {ex.Message}");
}


Console.WriteLine("=== Listing 4 ===");
try
{
    Listing04.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Listing 4 failed: {ex.Message}");
}
