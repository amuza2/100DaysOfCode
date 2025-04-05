using Octokit;

namespace webApiClient;

public class RunOctokit
{
    public static async Task<string> Run()
    {
        var github = new GitHubClient(new ProductHeaderValue("Packt"));
        const string username = "amuza2";
        var user = await github.User.Get(username);

        return $"{username} created profile at {user.CreatedAt.Year}";
    }
}
