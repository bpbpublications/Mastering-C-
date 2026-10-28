
// ---- Code Listing 1 ----
Console.WriteLine("=== Listing 1 ===");
Console.WriteLine("(pseudocode only - see comment in Program.cs)");

try { Console.WriteLine("=== Listing 2 ==="); Listing02.Run(); }
catch (Exception ex) { Console.WriteLine($"Listing 2 failed: {ex.Message}"); }

try { Console.WriteLine("=== Listing 3 ==="); Listing03.Run(); }
catch (Exception ex) { Console.WriteLine($"Listing 3 failed: {ex.Message}"); }

try { Console.WriteLine("=== Listing 4 ==="); Listing04.Run(); }
catch (Exception ex) { Console.WriteLine($"Listing 4 failed: {ex.Message}"); }

try { Console.WriteLine("=== Listing 5 ==="); Listing05.Run(); }
catch (Exception ex) { Console.WriteLine($"Listing 5 failed: {ex.Message}"); }

try { Console.WriteLine("=== Listing 6 ==="); Listing06.Run(); }
catch (Exception ex) { Console.WriteLine($"Listing 6 failed: {ex.Message}"); }

try { Console.WriteLine("=== Listing 7 ==="); Listing07.Run(); }
catch (Exception ex) { Console.WriteLine($"Listing 7 failed: {ex.Message}"); }

try { Console.WriteLine("=== Listing 8 ==="); await Listing08.RunAsync(); }
catch (Exception ex) { Console.WriteLine($"Listing 8 failed: {ex.Message}"); }

try { Console.WriteLine("=== Listing 9 ==="); Listing09.Run(); }
catch (Exception ex) { Console.WriteLine($"Listing 9 failed: {ex.Message}"); }

try { Console.WriteLine("=== Listing 10 ==="); Listing10.Run(); }
catch (Exception ex) { Console.WriteLine($"Listing 10 failed: {ex.Message}"); }

try { Console.WriteLine("=== Listing 11 ==="); Listing11.Run(); }
catch (Exception ex) { Console.WriteLine($"Listing 11 failed: {ex.Message}"); }
