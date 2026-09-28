#nullable enable

using System.CommandLine;

namespace Martian.CLI.Commands;

internal static partial class DefaultApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(CreateChatCompletionCommandApiCommand.Create());
                         command.Subcommands.Add(CreateMessageCommandApiCommand.Create());
                         command.Subcommands.Add(ListModelsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}