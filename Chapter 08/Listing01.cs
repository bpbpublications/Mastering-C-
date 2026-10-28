namespace Chapter8;

// ---- Code Listing 1 ----
public static class Listing01
{
    public static async Task RunAsync()
    {
        string data = await GetDataAsync();
        Console.WriteLine(data);
    }

    public static async Task<string> GetDataAsync()
    {
        using var httpClient = new HttpClient();
        return await httpClient.GetStringAsync("https://myfirstapi.com");
    }
}
