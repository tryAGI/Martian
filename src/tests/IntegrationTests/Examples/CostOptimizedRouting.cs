/*
order: 30
title: Cost-Optimized Routing
slug: cost-optimized-routing

Example showing how to use Martian's router parameters for cost-optimized model selection.
*/

namespace Martian.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_CostOptimizedRouting()
    {
        using var client = GetAuthenticatedClient();

        //// Use the router with cost constraints to optimize model selection.
        //// The models parameter restricts which models the router can choose from.
        //// willingness_to_pay controls cost vs. quality trade-off.
        var response = await client.CreateChatCompletionAsync(
            model: "openai/gpt-4.1-nano",
            messages: [new ChatCompletionMessage
            {
                Role = ChatCompletionMessageRole.User,
                Content = "Explain the concept of machine learning in one sentence.",
            }],
            models: ["openai/gpt-4.1-nano", "openai/gpt-4.1-mini"],
            maxCost: 0.01f,
            willingnessToPay: 0.1f);

        response.Should().NotBeNull();
        response.Choices.Should().NotBeNull();
        response.Choices!.Count.Should().BeGreaterThan(0);
    }
}
