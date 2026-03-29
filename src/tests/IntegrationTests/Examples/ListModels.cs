/*
order: 20
title: List Models
slug: list-models

Example showing how to list all available models with pricing information.
*/

namespace Martian.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListModels()
    {
        using var client = GetAuthenticatedClient();

        //// List all available models on the Martian Gateway
        var response = await client.ListModelsAsync();

        response.Should().NotBeNull();
        response.Data.Should().NotBeNull();
        response.Data!.Count.Should().BeGreaterThan(0);

        //// Each model includes pricing and reliability information
        var firstModel = response.Data[0];
        firstModel.Id.Should().NotBeNullOrWhiteSpace();
    }
}
