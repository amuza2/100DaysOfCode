using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace webApiClient;

public class StarWarsClient : BaseHttpClient
{
    private readonly HttpClient _client;
    HttpClientHandler handler;
    public StarWarsClient() : base("https://swapi.dev/api/")
    {
        // handler = new HttpClientHandler();
        // handler.ServerCertificateCustomValidationCallback = (HttpRequestMessage req, X509Certificate2 cert, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;
        // _client = new HttpClient(handler) { BaseAddress = new Uri("https://swapi.dev/api/") };
    }

    public async Task<ApiResult<IEnumerable<Film>>> GetFilms()
    {
        // var request = new HttpRequestMessage(HttpMethod.Get, new Uri("films", UriKind.Relative));
        // var response = await _client.SendAsync(request);

        // if (!response.IsSuccessStatusCode)
        //     throw new HttpRequestException(response.ReasonPhrase);

        // var context = await response.Content.ReadAsStringAsync();
        // var films = JsonSerializer.Deserialize<ApiResult<IEnumerable<Film>>>(context);

        var request = CreateGetRequest("films");
        var films = await SendGetManyRequests<Film>(request);

        return films;
    }
}
