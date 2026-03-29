/*
order: 10
title: Chat Completion
slug: chat-completion

Basic example showing how to create a chat completion via the Martian Gateway.
*/

namespace Martian.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ChatCompletion()
    {
        using var client = GetAuthenticatedClient();

        //// Send a chat completion request through the Martian Gateway
        var response = await client.CreateChatCompletionAsync(
            model: "openai/gpt-4.1-nano",
            messages: [new ChatCompletionMessage
            {
                Role = ChatCompletionMessageRole.User,
                Content = "What is 2 + 2?",
            }]);

        response.Should().NotBeNull();
        response.Choices.Should().NotBeNull();
        response.Choices!.Count.Should().BeGreaterThan(0);
        response.Model.Should().NotBeNullOrWhiteSpace();
    }
}
