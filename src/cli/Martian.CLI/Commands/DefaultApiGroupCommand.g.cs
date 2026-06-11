#nullable enable

using System.CommandLine;

namespace Martian.CLI.Commands;

internal static class DefaultApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(CreateChatCompletionCommandApiCommand.Create());
                         command.Subcommands.Add(CreateMessageCommandApiCommand.Create());
                         command.Subcommands.Add(ListModelsCommandApiCommand.Create());
        return command;
    }
}