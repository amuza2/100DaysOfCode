using Octokit;

namespace webApiClient;

public static class Demo
{
    public static async Task Run()
    {
        var client = new StarWarsClient();
        var filmResponse = await client.GetFilms();
        var films = filmResponse.Data;

        foreach (var film in films)
        {
            Console.WriteLine($"{film.ReleaseDate} {film.Title}");
        }
    }
}
