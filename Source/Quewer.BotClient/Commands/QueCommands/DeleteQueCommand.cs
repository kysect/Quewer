using System.Threading.Tasks;
using FluentResults;
using Tef.BotFramework.Abstractions;
using Tef.BotFramework.Core;

namespace Quewer.BotClient.Commands.QueCommands
{
    public class DeleteQueCommand : IBotCommand
    {
        public Result CanExecute(CommandArgumentContainer args)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<string>> ExecuteAsync(CommandArgumentContainer args)
        {
            throw new System.NotImplementedException();
        }

        public string CommandName { get; } = "delete-que";
        public string Description { get; }
        public string[] Args { get; } = { "Que name" };
    }
}