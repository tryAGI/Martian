#nullable enable

using System.CommandLine;

namespace Martian.CLI.Commands;

internal sealed record ResponseFormatOptionSet(
    Option<global::Martian.ResponseFormatType?> Type)
{
    public static ResponseFormatOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ResponseFormatOptionSet(
                        Type: new Option<global::Martian.ResponseFormatType?>($"--{normalizedPrefix}type")
                {
                    Description = @"The type of response format.",
                }
        );
    }
}