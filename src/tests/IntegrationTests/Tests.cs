namespace Martian.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static MartianClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MARTIAN_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("MARTIAN_API_KEY environment variable is not found.");

        var client = new MartianClient(apiKey);
        
        return client;
    }
}
