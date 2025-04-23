using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using RestSharp;

namespace webApiClient;

public class StarWarsClientRestSharp
{
    private readonly RestClient _client;

    public StarWarsClientRestSharp()
    {
        var handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback = (HttpRequestMessage req, X509Certificate2 cert, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;
        var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://swapi.dev/api/")
        };

        var option = new RestClientOptions
        {
            ConfigureMessageHandler = _ => handler,
            BaseUrl = new Uri("https://swapi.dev/api/")
        };

        _client = new RestClient(httpClient, option);

    }

    public async Task<ApiResult<IEnumerable<Film>>> GetFilms()
    {
        var request = new RestRequest("films");
        try
        {
            var film = await _client.GetAsync<ApiResult<IEnumerable<Film>>>(request);
            if (film == null)
            {
                System.Console.WriteLine("Failed to deserialize response or the request failed.");
                return new ApiResult<IEnumerable<Film>>
                {
                    Data = Enumerable.Empty<Film>()
                };
            }
            return film;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            return new ApiResult<IEnumerable<Film>>
            {
                Data = Enumerable.Empty<Film>()
            };
        }

    }
}
