
using System;

using Dapper;

namespace AssassinCore.Storage
{
    public struct CommandTextEventInfo
    {
        public CommandTextEventInfo(string commandText, object template)
        {
            CommandText = commandText ?? throw new ArgumentNullException(nameof(commandText));
            Parameters = template == null ? null : new DynamicParameters(template);
        }

        public string CommandText { get; }

        public DynamicParameters Parameters { get; }
    }
}