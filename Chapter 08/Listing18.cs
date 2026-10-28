namespace Chapter8;

// ---- Code Listing 18 ----
public static class Listing18
{
    private static readonly HttpClient _httpClient = new HttpClient();

    public static void Run()
    {
        var result = DownloadString("https://myfirstapi.com");
        Console.WriteLine(result);
    }

    public static string DownloadString(string url)
    {
        var request = _httpClient.GetAsync(url).Result;
        return request.Content.ReadAsStringAsync().Result;
    }
}
