namespace webApiClient;

public class EnvironmentVariable
{
    public static string GetOrThrow(string environmentVariable)
    {
        var variable = Environment.GetEnvironmentVariable(environmentVariable, EnvironmentVariableTarget.Machine);
        if (string.IsNullOrWhiteSpace(variable))
            throw new ArgumentException($"Environment variable {environmentVariable} not found");

        return variable;
    }
}
