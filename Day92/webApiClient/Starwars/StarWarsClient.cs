using System.Text.Json;

namespace webApiClient;

public class StarWarsClient
{
    private readonly HttpClient _client;
    public StarWarsClient()
    {
        _client = new HttpClient() { BaseAddress = new Uri("https://swapi.dev/api/") };
    }

    public async Task<ApiResult<IEnumerable<Film>>> GetFilms()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, new Uri("films", UriKind.Relative));
        var response = await _client.SendAsync(request);

        if (!response.IsSuccessStatusCode)
            throw new HttpRequestException(response.ReasonPhrase);

        var context = await response.Content.ReadAsStringAsync();
        var films = JsonSerializer.Deserialize<ApiResult<IEnumerable<Film>>>(context);

        return films;
    }
}
