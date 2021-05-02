using System.Threading.Tasks;
using FluentResults;
using Kysect.BotFramework.Core.CommandInvoking;

namespace Quewer.BotClient.Commands.QueCommands
{
    public class QueSwapCommand : IBotCommand
    {
        public class Descriptor : BotCommandDescriptor<QueSwapCommand>
        {
            public Descriptor() : base("que-swap", string.Empty, new[] { "Que name", "Queser id" })
            {
            }
        }

        public Result CanExecute(CommandArgumentContainer args)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<string>> ExecuteAsync(CommandArgumentContainer args)
        {
            throw new System.NotImplementedException();
        }
    }
}