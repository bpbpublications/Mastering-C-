namespace Chapter15;

// ---- Code Listing 2 ----
public static class Listing02
{
    public static void Run()
    {
        string path = @"D:\Workarea";

        try
        {
            if (Directory.Exists(path))
            {
                Console.WriteLine("The directory was created at: " + Directory.GetCreationTime(path).ToShortTimeString());
                return;
            }

            Console.WriteLine("Directory not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occured: {0}", ex.ToString());
        }
    }
}
