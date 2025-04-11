using System.Buffers.Text;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace webApiClient;

public class GitHttp
{
    public static string GithubClientId { get; } = Environment.GetEnvironmentVariable("GithubClientId", EnvironmentVariableTarget.Machine);
    public static string GithubSecret { get; } = Environment.GetEnvironmentVariable("GithubSecret", EnvironmentVariableTarget.Machine);
    public static string GithubPersonalAccessToken { get; } = Environment.GetEnvironmentVariable("GithubPersonalAccessToken", EnvironmentVariableTarget.Machine);
    private static HttpClient _client;


    static GitHttp()
    {
        _client = new HttpClient
        {
            BaseAddress = new Uri("https://api.github.com")
        };
        _client.DefaultRequestHeaders.Add("User-Agent", "Packt");
    }

    public static async Task GetUser()
    {
        const string username = "amuza2";
        var request = new HttpRequestMessage(HttpMethod.Get, new Uri($"users/{username}", UriKind.Relative));
        var response = await _client.SendAsync(request);
        var content = await response.Content.ReadAsStringAsync();
        var user = JsonSerializer.Deserialize<User>(content);

        Console.WriteLine($"{user.name} Created profile at {user.created_at.ToLongDateString()}");
    }

    public static async Task GetUser61Times(string authHeader)
    {
        const int rateLimit = 60;
        for (int i = 0; i < rateLimit + 1; i++)
        {
            const string username = "amuza2";
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri($"users/{username}", UriKind.Relative));
            request.Headers.CacheControl = new CacheControlHeaderValue() { NoCache = true };

            request.Headers.Add("Authorization", authHeader);

            var response = await _client.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }

            var content = await response.Content.ReadAsStringAsync();

            var user = JsonSerializer.Deserialize<User>(content);

            Console.WriteLine($"{i + 1} {user.name} crearted profile at {user.created_at}");
        }
    }

    public static string GetBasicToken()
    {
        var id = GithubClientId;
        var secret = GithubSecret;
        var tokenRow = $"{id}:{secret}";
        var tokenBytes = Encoding.UTF8.GetBytes(tokenRow);
        var token = Convert.ToBase64String(tokenBytes);

        return "Basic " + token;
    }

    public static void Dispose() => _client.Dispose();
}
