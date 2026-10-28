namespace Chapter15;

// ---- Code Listing 3 ----
public static class Listing03
{
    public static void Run()
    {
        DriveInfo driveInfo = new DriveInfo(@"D:\");
        Console.WriteLine("Total free space: " + driveInfo.TotalFreeSpace);
        Console.WriteLine("Volume label: " + driveInfo.VolumeLabel);

        DirectoryInfo directoryInfo = driveInfo.RootDirectory;
        Console.WriteLine(directoryInfo.Attributes.ToString());
    }
}
