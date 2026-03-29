/*
order: 40
title: MEAI Tools
slug: meai-tools

Example showing how to use Martian as AIFunction tools with any IChatClient.
*/

namespace Martian.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_AsListModelsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an AIFunction tool for listing available models
        var listModelsTool = client.AsListModelsTool();

        listModelsTool.Name.Should().Be("MartianListModels");
        listModelsTool.Description.Should().Contain("Martian Gateway");
    }

    [TestMethod]
    public async Task Example_AsChatCompletionTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an AIFunction tool for chat completions with cost constraints
        var chatTool = client.AsChatCompletionTool(
            model: "openai/gpt-4.1-nano",
            maxCost: 0.01f);

        chatTool.Name.Should().Be("MartianChatCompletion");
        chatTool.Description.Should().Contain("Martian Gateway");
    }

    [TestMethod]
    public async Task Example_AsRoutedChatTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an AIFunction tool that uses the Martian router for cost-optimized routing
        var routedTool = client.AsRoutedChatTool(
            models: ["openai/gpt-4.1-nano", "openai/gpt-4.1-mini"],
            willingnessToPay: 0.1f);

        routedTool.Name.Should().Be("MartianRoutedChat");
        routedTool.Description.Should().Contain("router");
    }

    [TestMethod]
    public async Task Example_AsAnthropicMessageTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an AIFunction tool for Anthropic-compatible messages
        var messageTool = client.AsAnthropicMessageTool(
            model: "anthropic/claude-sonnet-4-20250514",
            maxTokens: 512);

        messageTool.Name.Should().Be("MartianAnthropicMessage");
        messageTool.Description.Should().Contain("Anthropic");
    }
}
