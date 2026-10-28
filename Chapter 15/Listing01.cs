namespace Chapter15;

// ---- Code Listing 1 ----
public static class Listing01
{
    public static void Run()
    {
        string path = @"D:\Workarea";

        try
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Directory not found.");
                return;
            }

            Directory.Delete(path, true);
            Console.WriteLine("The directory and its subdirectories and files was deleted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occured: {0}", ex.ToString());
        }
    }
}
