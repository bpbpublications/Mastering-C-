namespace Chapter8;

// ---- Code Listing 17 ----
public static class Listing17
{
    private static readonly HttpClient _httpClient = new HttpClient();

    public static async Task RunAsync()
    {
        var result = await DownloadString("https://myfirstapi.com");
        Console.WriteLine(result);
    }

    public static async Task<string> DownloadString(string url)
    {
        var request = await _httpClient.GetAsync(url);
        return await request.Content.ReadAsStringAsync();
    }
}
